using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace 棋牌類遊戲
{
    public partial class frmGame : Form
    {
        /// <summary>牌堆（剩餘未發的牌，編號 1~52）</summary>
        private List<int> drawPile = new List<int>();

        /// <summary>玩家手牌</summary>
        private List<int> playerHand = new List<int>();

        /// <summary>三個電腦手牌 [0]=A, [1]=B, [2]=C</summary>
        private List<int>[] aiHand = new List<int>[3];

        /// <summary>玩家完成的書（點數列表）</summary>
        private List<int> playerBooks = new List<int>();

        /// <summary>電腦完成的書 [0]=A, [1]=B, [2]=C</summary>
        private List<int>[] aiBooks = new List<int>[3];

        /// <summary>玩家目前選取的牌點數（-1 = 尚未選取）</summary>
        private int selectedRank = -1;

        /// <summary>目前是否為玩家回合</summary>
        private bool isPlayerTurn = true;

        /// <summary>遊戲是否進行中</summary>
        private bool gameStarted = false;

        /// <summary>目前的局號 (用於防堵非同步幽靈進程)</summary>
        private int currentSessionId = 0;

        /// <summary>玩家手牌對應的 PictureBox（動態產生）</summary>
        private List<PictureBox> playerCardPics = new List<PictureBox>();

        /// <summary>背景音樂播放器</summary>
        private System.Media.SoundPlayer bgmPlayer;

        /// <summary>宣告一個全域變數用來裝結算畫面</summary>
        private Panel pnlResultOverlay;

        // ══════════════════════════════════════════════════
        // 點數對照（0=A,1=2,...,12=K；花色 0~3）
        // ══════════════════════════════════════════════════
        private static readonly string[] RANK_NAMES =
            { "A","2","3","4","5","6","7","8","9","10","J","Q","K" };

        public frmGame()
        {
            InitializeComponent();
            this.Size = new Size(980, 768);

            InitializeUI();
            InitializeGame();
        }

        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void InitializeUI()
        {
            this.Size = new Size(980, 768);
            this.MinimumSize = new Size(980, 768);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ══════════════════════════════════════
            // 1. pnlCB — 電腦B（上方）
            // ══════════════════════════════════════
            pnlCB.Padding = new Padding(10);
            pnlCB.Height = 130;
            lblCB.Location = new Point((pnlCB.Width - lblCB.Width) / 2, 8);
            lblStatus_B.Location = new Point((pnlCB.Width - lblStatus_B.Width) / 2, 35);
            picCB.Size = new Size(64, 92); // 配合整體縮小
            picCB.Location = new Point((pnlCB.Width - picCB.Width) / 2 - 250, 10);
            btnRule.Size = new Size(150, 50);
            btnRule.Location = new Point(750, 30);

            // ══════════════════════════════════════
            // 2. pnlPlayer — 玩家（下方）
            // ══════════════════════════════════════
            pnlPlayer.Height = 200;
            pnlPlayer.BackColor = Color.FromArgb(28, 40, 20);

            lblPlayer.Location = new Point(20, 12);
            lblStatus_P.Location = new Point(pnlPlayer.Width - 162, 12);

            // 手牌 FlowLayoutPanel 【重點優化：開啟自動捲軸】
            flpCard.Location = new Point(30, (pnlPlayer.Height - 100) / 2);
            flpCard.Size = new Size(680, 130);
            flpCard.Padding = new Padding(0);

            // 【新增防閃爍】：套用雙重緩衝到手牌區
            EnableDoubleBuffering(flpCard);

            // 詢問按鈕
            btnAsk.Size = new Size(130, 42);
            btnAsk.Location = new Point(pnlPlayer.Width - 165, 60);
            btnAsk.Click += new EventHandler(btnAsk_Click);

            // 【新增：顯示目前選擇了什麼牌的提示標籤】
            Label lblSelectedHint = new Label();
            lblSelectedHint.Name = "lblSelectedHint";
            lblSelectedHint.Text = "💡 請點擊你要詢問的牌";
            lblSelectedHint.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            lblSelectedHint.ForeColor = Color.Gold;
            lblSelectedHint.AutoSize = true;
            lblSelectedHint.Location = new Point(pnlPlayer.Width - 170, 115); // 放在按鈕下方
            pnlPlayer.Controls.Add(lblSelectedHint);

            // ══════════════════════════════════════
            // 3. pnlCC — 電腦C（左）
            // ══════════════════════════════════════
            pnlCC.Width = 140;
            lblCC.Location = new Point(10, 20);
            lblStatus_C.Location = new Point(10, 48);
            picCC.Size = new Size(64, 92);
            picCC.Location = new Point((pnlCC.Width - picCC.Width) / 2, 80);

            // ══════════════════════════════════════
            // 4. pnlCA — 電腦A（右）
            // ══════════════════════════════════════
            pnlCA.Width = 140;
            lblCA.Location = new Point(10, 20);
            lblStatus_A.Location = new Point(10, 48);
            picCA.Size = new Size(64, 92);
            picCA.Location = new Point((pnlCA.Width - picCA.Width) / 2, 80);

            // ══════════════════════════════════════
            // 5. pnlPublic — 中央資訊板
            // ══════════════════════════════════════
            pnlPublic.Size = new Size(500, 310);
            picPublic.Size = new Size(100, 145);
            picPublic.Location = new Point(30, 25);
            picPublic.SizeMode = PictureBoxSizeMode.StretchImage;
            lblRemain.AutoSize = true;
            lblRemain.Location = new Point(150, 45);

            // lstInfo — 確保長文字也能水平捲動
            lstInfo.Location = new Point(20, 185);
            lstInfo.Size = new Size(pnlPublic.Width - 40, pnlPublic.Height - 185 - 15);
            lstInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            lstInfo.HorizontalScrollbar = true;

            if (btnRestart != null)
            {
                pnlPublic.Controls.Add(btnRestart);
                btnRestart.Size = new Size(150, 50);
                btnRestart.Location = new Point(150, 90);
                btnRestart.Click -= btnRestart_Click;
                btnRestart.Click += new EventHandler(btnRestart_Click);
            }

            lblChoice.Location = new Point(350, 47); 
            lblChoice.Size = new Size(200, 30);

            if (cmbMusic != null)
            {
                cmbMusic.Size = new Size(150, 50);
                cmbMusic.Location = new Point(350, 75);
            }

            if (btnPlay != null)
            {
                btnPlay.Size = new Size(120, 40);
                btnPlay.Location = new Point(530, 40);
                btnPlay.Click -= btnPlay_Click;
                btnPlay.Click += new EventHandler(btnPlay_Click);
            }

            if (btnStop != null)
            {
                btnStop.Size = new Size(120, 40);
                btnStop.Location = new Point(530, 100);
                btnStop.Click -= btnStop_Click;
                btnStop.Click += new EventHandler(btnStop_Click);
            }

            CenterPublicPanel();
            this.Resize += new EventHandler(frmGame_Resize);
        }

        private void CenterPublicPanel()
        {
            int leftW = pnlCC.Width;
            int rightW = pnlCA.Width;
            int usableW = this.ClientSize.Width - leftW - rightW;
            int centerX = leftW + (usableW - pnlPublic.Width) / 2;

            int topH = pnlCB.Height;
            int bottomH = pnlPlayer.Height;
            int availH = this.ClientSize.Height - topH - bottomH;
            int centerY = topH + (availH - pnlPublic.Height) / 2;

            pnlPublic.Location = new Point(centerX, centerY);
        }

        private void frmGame_Resize(object sender, EventArgs e)
        {
            CenterPublicPanel();
            btnAsk.Location = new Point(pnlPlayer.Width - 165, 60);
            lblStatus_P.Location = new Point(pnlPlayer.Width - 200, 12);
            lstInfo.Size = new Size(pnlPublic.Width - 40, pnlPublic.Height - 185 - 15);

            // 連動調整提示標籤位置
            Control lblHint = pnlPlayer.Controls.Find("lblSelectedHint", false).FirstOrDefault();
            if (lblHint != null)
            {
                lblHint.Location = new Point(pnlPlayer.Width - 170, 115);
            }
            if (pnlResultOverlay != null)
            {
                // 讓遮罩強制跟隨視窗大小
                pnlResultOverlay.Bounds = this.ClientRectangle;

                // 讓裡面的結算卡片重新置中
                if (pnlResultOverlay.Controls.Count > 0)
                {
                    Panel modal = (Panel)pnlResultOverlay.Controls[0];
                    modal.Location = new Point(
                        (pnlResultOverlay.Width - modal.Width) / 2,
                        (pnlResultOverlay.Height - modal.Height) / 2
                    );
                }
            }
        }

        private void InitializeGame()
        {
            currentSessionId++;
            lstInfo.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                aiHand[i] = new List<int>();
                aiBooks[i] = new List<int>();
            }
            playerHand.Clear();
            playerBooks.Clear();
            selectedRank = -1;

            drawPile = Enumerable.Range(1, 52).ToList();
            Shuffle(drawPile);

            for (int i = 0; i < 5; i++)
            {
                playerHand.Add(DrawFromPile());
                for (int a = 0; a < 3; a++)
                    aiHand[a].Add(DrawFromPile());
            }

            CheckAndRemoveBooks(playerHand, playerBooks);
            for (int a = 0; a < 3; a++)
                CheckAndRemoveBooks(aiHand[a], aiBooks[a]);

            gameStarted = true;
            isPlayerTurn = true;

            RefreshAll();
            AddLog("請選擇一張手牌，然後按「詢問」按鈕");
        }

        private void Shuffle(List<int> list)
        {
            Random rand = new Random();
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
        }

        private int DrawFromPile()
        {
            if (drawPile.Count == 0) return -1;
            int card = drawPile[0];
            drawPile.RemoveAt(0);
            return card;
        }

        private int GetRank(int cardNum) => (cardNum - 1) / 4;

        private bool CheckAndRefillHand(List<int> hand, string playerName)
        {
            if (hand.Count > 0) return true;

            if (drawPile.Count > 0)
            {
                int drawn = DrawFromPile();
                hand.Add(drawn);
                AddLog($"🌟 {playerName} 手牌已空，自動從牌堆補一張牌。");
                return true;
            }

            return false;
        }

        private void CheckAndRemoveBooks(List<int> hand, List<int> books)
        {
            for (int rank = 0; rank < 13; rank++)
            {
                var same = hand.Where(c => GetRank(c) == rank).ToList();
                if (same.Count == 4)
                {
                    books.Add(rank);
                    foreach (var c in same) hand.Remove(c);
                    CheckAndRemoveBooks(hand, books);
                    return;
                }
            }
        }

        private Image GetCardImage(int cardNum)
        {
            try { return Properties.Resources.ResourceManager.GetObject($"pic{cardNum}") as Image; }
            catch { return null; }
        }

        private Image GetBackImage()
        {
            try { return Properties.Resources.ResourceManager.GetObject("back") as Image; }
            catch { return null; }
        }

        private void RefreshAll()
        {
            RefreshPlayerHand();
            RefreshAIHand(0, picCA, lblStatus_A);
            RefreshAIHand(1, picCB, lblStatus_B);
            RefreshAIHand(2, picCC, lblStatus_C);
            RefreshRemain();
            RefreshScores();
            RefreshAskButton();
        }

        private void RefreshPlayerHand()
        {
            // 【新增防閃爍】：暫停畫面配置，等全部畫完再顯示
            flpCard.SuspendLayout();

            flpCard.Controls.Clear();
            playerCardPics.Clear();

            var sorted = playerHand.OrderBy(c => GetRank(c)).ToList();

            foreach (int card in sorted)
            {
                int rank = GetRank(card);
                PictureBox pb = new PictureBox
                {
                    // 【重點優化：縮小尺寸，容納更多牌】
                    Size = new Size(64, 92),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = GetCardImage(card),
                    Tag = rank,
                    Margin = new Padding(3, 2, 3, 2),
                    Cursor = isPlayerTurn ? Cursors.Hand : Cursors.Default,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                if (rank == selectedRank)
                    pb.BackColor = Color.FromArgb(212, 144, 28);
                else
                    pb.BackColor = Color.White;

                if (isPlayerTurn)
                    pb.Click += PlayerCard_Click;

                flpCard.Controls.Add(pb);
                playerCardPics.Add(pb);
            }

            lblStatus_P.Text = $"手牌：{playerHand.Count} ｜ 書：{playerBooks.Count}";

            // 【新增防閃爍】：恢復畫面配置並一次性渲染
            flpCard.ResumeLayout();
        }

        private void RefreshAIHand(int aiIndex, PictureBox pic, Label statusLabel)
        {
            pic.Image = GetBackImage();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            statusLabel.Text = $"手牌：{aiHand[aiIndex].Count} ｜ 書：{aiBooks[aiIndex].Count}";
        }

        private void RefreshRemain()
        {
            lblRemain.Text = $"剩餘牌數：{drawPile.Count}";
        }

        private void RefreshScores()
        {
            lblStatus_P.Text = $"手牌：{playerHand.Count} ｜ 書：{playerBooks.Count}";
            lblStatus_A.Text = $"手牌：{aiHand[0].Count} ｜ 書：{aiBooks[0].Count}";
            lblStatus_B.Text = $"手牌：{aiHand[1].Count} ｜ 書：{aiBooks[1].Count}";
            lblStatus_C.Text = $"手牌：{aiHand[2].Count} ｜ 書：{aiBooks[2].Count}";
        }

        // ══════════════════════════════════════════════════
        // 更新按鈕與提示標籤
        // ══════════════════════════════════════════════════
        private void RefreshAskButton()
        {
            btnAsk.Enabled = isPlayerTurn && selectedRank >= 0 && gameStarted;

            // 【重點優化：動態更新選擇提示】
            Label lblHint = pnlPlayer.Controls.Find("lblSelectedHint", false).FirstOrDefault() as Label;
            if (lblHint != null)
            {
                if (selectedRank >= 0)
                    lblHint.Text = $"已選擇：「 {RANK_NAMES[selectedRank]} 」";
                else
                    lblHint.Text = "請點擊你要詢問的牌";
            }
        }

        private void AddLog(string msg)
        {
            lstInfo.Items.Add(msg);
            lstInfo.TopIndex = lstInfo.Items.Count - 1;
        }

        private void PlayerCard_Click(object sender, EventArgs e)
        {
            if (!isPlayerTurn) return;

            PictureBox pb = (PictureBox)sender;
            int clickedRank = (int)pb.Tag;

            selectedRank = (selectedRank == clickedRank) ? -1 : clickedRank;

            RefreshPlayerHand();
            RefreshAskButton();
        }

        private async void btnAsk_Click(object sender, EventArgs e)
        {
            if (!isPlayerTurn || selectedRank < 0) return;
            int session = currentSessionId; // 記錄當下局號
            int rank = selectedRank;
            string rName = RANK_NAMES[rank];
            selectedRank = -1;
            isPlayerTurn = false;
            btnAsk.Enabled = false;

            AddLog($"── 你的回合：詢問所有電腦是否有「{rName}」──");

            int got = 0;
            string[] aiNames = { "電腦A", "電腦B", "電腦C" };

            for (int a = 0; a < 3; a++)
            {
                var cards = aiHand[a].Where(c => GetRank(c) == rank).ToList();
                if (cards.Count > 0)
                {
                    foreach (var c in cards)
                    {
                        aiHand[a].Remove(c);
                        playerHand.Add(c);
                    }
                    got += cards.Count;
                    AddLog($"  {aiNames[a]} 給了你 {cards.Count} 張「{rName}」");
                }
                else
                {
                    AddLog($"  {aiNames[a]} 沒有「{rName}」");
                }
            }

            RefreshAll();

            if (got > 0)
            {
                AddLog($"共獲得 {got} 張！");
                CheckAndRemoveBooks(playerHand, playerBooks);
            }
            else
            {
                AddLog($"所有電腦都沒有「{rName}」，抽牌");
                int drawn = DrawFromPile();
                if (drawn != -1)
                {
                    playerHand.Add(drawn);
                    int drawnRank = GetRank(drawn);
                    AddLog($"你從牌堆抽到了「{RANK_NAMES[drawnRank]}」");
                    CheckAndRemoveBooks(playerHand, playerBooks);
                }
                else
                {
                    AddLog("牌堆已空！");
                }
            }

            RefreshAll();
            if (CheckGameOver()) return;

            AddLog("回合結束，換下一位");
            await Task.Delay(1000);

            if (currentSessionId != session) return;
            await RunAITurns();
        }

        private async Task RunAITurns()
        {
            int session = currentSessionId; // 記錄當下局號
            string[] aiNames = { "電腦A", "電腦B", "電腦C" };

            // 執行三位電腦的回合
            for (int a = 0; a < 3; a++)
            {
                if (CheckGameOver() || currentSessionId != session) return;

                AddLog($"── {aiNames[a]} 的回合 ──");
                await Task.Delay(500);

                if (currentSessionId != session) return; // 防護

                // 注意：這裡多傳了一個 session 參數給 AI 執行
                await RunSingleAITurn(a, aiNames[a], session);

                if (currentSessionId != session) return; // 防護

                RefreshAll();
                await Task.Delay(400);
                if (currentSessionId != session) return;
            }

            // 電腦回合結束，準備輪回玩家
            if (!CheckGameOver() && currentSessionId == session)
            {
                if (!CheckAndRefillHand(playerHand, "你"))
                {
                    AddLog("══ 你無牌可出且牌堆已空，自動跳過回合 ══");
                    RefreshAll();
                    await Task.Delay(1000);
                    if (currentSessionId != session) return;

                    isPlayerTurn = false;
                    await RunAITurns();
                }
                else
                {
                    isPlayerTurn = true;
                    AddLog("══ 輪回到你了，請選牌並詢問 ══");
                    RefreshAll();
                    RefreshAskButton();
                }
            }
        }

        private async Task RunSingleAITurn(int a, string aiName, int session)
        {
            // 回合「開始時」如果沒牌，這裡會負責補牌 (維持不變)
            if (!CheckAndRefillHand(aiHand[a], aiName))
            {
                AddLog($"{aiName} 無牌可出且牌堆已空，跳過回合");
                return;
            }

            RefreshAll();
            await Task.Delay(400);
            if (currentSessionId != session) return;

            Random rand = new Random();
            var ownRanks = aiHand[a].Select(c => GetRank(c)).Distinct().ToList();

            if (ownRanks.Count == 0) return;

            int askRank = ownRanks[rand.Next(ownRanks.Count)];
            string rName = RANK_NAMES[askRank];

            AddLog($"{aiName} 詢問大家是否有「{rName}」");
            await Task.Delay(600);

            int got = 0;

            var fromPlayer = playerHand.Where(c => GetRank(c) == askRank).ToList();
            if (fromPlayer.Count > 0)
            {
                foreach (var c in fromPlayer) { playerHand.Remove(c); aiHand[a].Add(c); }
                got += fromPlayer.Count;
                AddLog($"  你給了 {aiName} {fromPlayer.Count} 張「{rName}」");
            }
            else AddLog($"  你沒有「{rName}」");

            for (int b = 0; b < 3; b++)
            {
                if (b == a) continue;
                string bName = new[] { "電腦A", "電腦B", "電腦C" }[b];
                var fromAI = aiHand[b].Where(c => GetRank(c) == askRank).ToList();
                if (fromAI.Count > 0)
                {
                    foreach (var c in fromAI) { aiHand[b].Remove(c); aiHand[a].Add(c); }
                    got += fromAI.Count;
                    AddLog($"  {bName} 給了 {aiName} {fromAI.Count} 張「{rName}」");
                }
                else AddLog($"  {bName} 沒有「{rName}」");
            }

            RefreshAll();
            await Task.Delay(400);
            if (currentSessionId != session) return;

            if (got > 0)
            {
                AddLog($"{aiName} 共獲得 {got} 張");
                CheckAndRemoveBooks(aiHand[a], aiBooks[a]);
            }
            else
            {
                AddLog($"所有人都沒有，{aiName}抽牌");

                int drawn = DrawFromPile();
                if (drawn != -1)
                {
                    aiHand[a].Add(drawn);
                    AddLog($"{aiName} 從牌堆抽了一張牌");
                    CheckAndRemoveBooks(aiHand[a], aiBooks[a]);
                }
                else
                {
                    AddLog("牌堆已空");
                }
            }

            RefreshAll();
            if (CheckGameOver()) return;

            await Task.Delay(500);
        }

        private bool CheckGameOver()
        {
            int totalBooks = playerBooks.Count
                           + aiBooks[0].Count + aiBooks[1].Count + aiBooks[2].Count;

            bool allHandsEmpty = playerHand.Count == 0
                              && aiHand[0].Count == 0
                              && aiHand[1].Count == 0
                              && aiHand[2].Count == 0;

            if (totalBooks < 13 && !(drawPile.Count == 0 && allHandsEmpty))
                return false;

            gameStarted = false;
            isPlayerTurn = false;
            RefreshAll();
            ShowResult();
            return true;
        }

        private void ShowResult()
        {
            try
            {
                if (bgmPlayer != null)
                {
                    bgmPlayer.Stop();
                    bgmPlayer.Dispose();
                }

                // 根據 ComboBox 的 Index 選擇對應的 Resources 音檔
                System.IO.Stream musicStream = null;
                musicStream = Properties.Resources.reward;

                // 執行播放
                if (musicStream != null)
                {
                    bgmPlayer = new System.Media.SoundPlayer(musicStream);
                    bgmPlayer.PlayLooping(); // 使用 PlayLooping 讓背景音樂無限循環
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放音樂時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int[] scores =
            {
                playerBooks.Count,
                aiBooks[0].Count,
                aiBooks[1].Count,
                aiBooks[2].Count
            };
            string[] names = { "你", "電腦A", "電腦B", "電腦C" };

            int max = scores.Max();
            var winners = names.Where((n, i) => scores[i] == max).ToList();

            string winMsg = winners.Contains("你")
                ? (winners.Count == 1 ? "🎉 你贏了！" : "🤝 平局！")
                : $"🏆 {string.Join("、", winners)} 獲勝！";

            AddLog("══════════════════════════════════");
            AddLog($"遊戲結束 {winMsg}");
            for (int i = 0; i < 4; i++)
                AddLog($"  {names[i]}：{scores[i]} 本書");
            AddLog("══════════════════════════════════");

            string detail = string.Join("\n\n", names.Select((n, i) => $"{n}：{scores[i]} 本書"));

            // 呼叫絕對不跑版的動態結算畫面
            BuildResultScreen(winMsg, detail);
        }

        // ══════════════════════════════════════════════════
        // 動態生成：防跑版的遊戲結算畫面
        // ══════════════════════════════════════════════════
        private void BuildResultScreen(string winTitle, string scoreDetails)
        {
            // 1. 暫停視窗渲染，避免元件一個個蹦出來造成的閃爍
            this.SuspendLayout();

            // 防呆：如果已經有結算畫面了，先清掉舊的
            if (pnlResultOverlay != null)
            {
                this.Controls.Remove(pnlResultOverlay);
                pnlResultOverlay.Dispose();
            }

            // 2. 遮罩層 (啟用雙重緩衝防閃爍)
            pnlResultOverlay = new Panel();
            EnableDoubleBuffering(pnlResultOverlay);
            pnlResultOverlay.Bounds = this.ClientRectangle;
            pnlResultOverlay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlResultOverlay.BackColor = Color.FromArgb(220, 25, 35, 20);
            this.Controls.Add(pnlResultOverlay);
            pnlResultOverlay.BringToFront();

            // 3. 資訊卡片
            Panel pnlModal = new Panel();
            pnlModal.Size = new Size(600, 500);
            pnlModal.Location = new Point((pnlResultOverlay.Width - pnlModal.Width) / 2, (pnlResultOverlay.Height - pnlModal.Height) / 2);
            pnlModal.BackColor = Color.FromArgb(40, 50, 30);
            pnlModal.BorderStyle = BorderStyle.FixedSingle;
            pnlResultOverlay.Controls.Add(pnlModal);

            // 4. 標題
            Label lblTitle = new Label();
            lblTitle.Text = winTitle;
            lblTitle.Font = new Font("微軟正黑體", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(600, 60);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Location = new Point(0, 30);
            pnlModal.Controls.Add(lblTitle);

            // 5. 分數明細
            Label lblScores = new Label();
            lblScores.Text = "【 最終結算 】\n\n" + scoreDetails;
            lblScores.Font = new Font("微軟正黑體", 16F, FontStyle.Regular);
            lblScores.ForeColor = Color.White;
            lblScores.AutoSize = false;
            lblScores.Size = new Size(600, 280);
            lblScores.TextAlign = ContentAlignment.TopCenter;
            lblScores.Location = new Point(0, 110);
            pnlModal.Controls.Add(lblScores);

            // 6. 按鈕區
            int btnWidth = 160;
            int btnSpacing = 35;
            int startX = (pnlModal.Width - ((btnWidth * 2) + btnSpacing)) / 2;

            Button btnRestartApp = new Button();
            btnRestartApp.Text = "重新開始";
            btnRestartApp.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            btnRestartApp.Size = new Size(btnWidth, 50);
            btnRestartApp.Location = new Point(startX, 400);
            btnRestartApp.BackColor = Color.FromArgb(151, 124, 0);
            btnRestartApp.ForeColor = Color.White;
            btnRestartApp.FlatStyle = FlatStyle.Flat;
            btnRestartApp.Cursor = Cursors.Hand;
            btnRestartApp.Click += (s, e) => { Application.Restart(); Environment.Exit(0);};
            pnlModal.Controls.Add(btnRestartApp);

            Button btnExit = new Button();
            btnExit.Text = "結束遊戲";
            btnExit.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            btnExit.Size = new Size(btnWidth, 50);
            btnExit.Location = new Point(startX + btnWidth + btnSpacing, 400);
            btnExit.BackColor = Color.IndianRed;
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Click += (s, e) => { Application.Exit(); };
            pnlModal.Controls.Add(btnExit);

            // 7. 恢復渲染，一次性呈現畫面
            this.ResumeLayout();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmbMusic == null || cmbMusic.SelectedIndex < 0) return;

            try
            {
                // 如果目前有音樂在播，先停止並釋放資源
                if (bgmPlayer != null)
                {
                    bgmPlayer.Stop();
                    bgmPlayer.Dispose();
                }

                // 根據 ComboBox 的 Index 選擇對應的 Resources 音檔
                System.IO.Stream musicStream = null;
                switch (cmbMusic.SelectedIndex)
                {
                    case 0:
                        musicStream = Properties.Resources.music1;
                        break;
                    case 1:
                        musicStream = Properties.Resources.music2;
                        break;
                    case 2:
                        musicStream = Properties.Resources.music3;
                        break;
                }

                // 執行播放
                if (musicStream != null)
                {
                    bgmPlayer = new System.Media.SoundPlayer(musicStream);
                    bgmPlayer.PlayLooping(); // 使用 PlayLooping 讓背景音樂無限循環
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放音樂時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (bgmPlayer != null)
                {
                    bgmPlayer.Stop();
                }
            }
            catch { /* 忽略停止時可能發生的極端錯誤 */ }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // 彈出確認視窗，避免玩家誤觸
            DialogResult result = MessageBox.Show(
                "確定要放棄當前進度，重新開始一局新遊戲嗎？",
                "重新開始",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstInfo.Items.Clear();
                InitializeGame();
            }
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            string rules = "【 遊戲規則與流程 】" + Environment.NewLine + Environment.NewLine +
                   "1. 回合順序：玩家 → 電腦A → 電腦B → 電腦C" + Environment.NewLine +
                   "2. 輪到自己時，選擇一張手牌並詢問所有對手是否有相同數字" + Environment.NewLine +
                   "3. 若對手有該數字，拿走卡牌並切換到下一位玩家" + Environment.NewLine +
                   "4. 若對手皆無此牌，系統會自動從中央抽取一張牌" + Environment.NewLine +
                   "5. 湊齊 4 張同數字卡牌即完成「一本書」並得分" + Environment.NewLine +
                   "6. 重複此流程直到所有牌都被組成書，擁有最多本書的玩家獲勝";

            MessageBox.Show(rules, "遊戲規則", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}