using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 棋牌類遊戲
{
    public partial class frmStart : Form
    {
        private System.Media.SoundPlayer musicPlayer;
        public frmStart()
        {
            InitializeComponent();
            this.Resize += new EventHandler(frmStart_Resize);
            this.Load += new EventHandler(frmStart_Load);
            SetupStartScreen();
        }
        private void SetupStartScreen()
        {
            this.Size = new Size(800, 600);
            if (btnStart != null)
            {
                btnStart.Click += new EventHandler(btnStart_Click);
            }
        }
        private void CenterElements()
        {
            // 防止視窗縮到太小導致計算出負值而報錯
            if (this.ClientSize.Width <= 0 || this.ClientSize.Height <= 0) return;

            // 1. 【主標題】水平置中，且固定靠頁面上方 (距離頂端 40 像素)
            if (lblTitle != null)
            {
                lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
                lblTitle.Top = 80;
            }

            // 2. 【遊戲規則面板】處理大小，並設定為「畫面正中間」
            if (pnlRule != null)
            {
                int maxRuleWidth = 0;
                int maxRuleHeight = 0;

                foreach (Control ctrl in pnlRule.Controls)
                {
                    if (ctrl is Label && ctrl.Name.StartsWith("lblT"))
                    {
                        ctrl.AutoSize = true;
                        ctrl.PerformLayout();

                        if (ctrl.Width > maxRuleWidth)
                        {
                            maxRuleWidth = ctrl.Width;
                        }

                        if (ctrl.Bottom > maxRuleHeight)
                        {
                            maxRuleHeight = ctrl.Bottom;
                        }
                    }
                }

                int newPanelWidth = maxRuleWidth + 80;
                if (newPanelWidth > pnlRule.Width)
                {
                    pnlRule.Width = newPanelWidth;
                }

                if ((maxRuleHeight + 30) > pnlRule.Height)
                {
                    pnlRule.Height = maxRuleHeight + 30;
                }

                // ➔ 關鍵修改：將整個白色的 pnlRule 水平與垂直皆置中（畫面正中間）
                pnlRule.Left = (this.ClientSize.Width - pnlRule.Width) / 2;
                pnlRule.Top = (this.ClientSize.Height - pnlRule.Height) / 2;

                // 將 pnlRule 內部的標題 (lblHead) 置中
                if (lblHead != null)
                {
                    lblHead.Left = (pnlRule.Width - lblHead.Width) / 2;
                }

                // 將所有規則文字 (lblT1...) 排列靠左齊
                foreach (Control ctrl in pnlRule.Controls)
                {
                    if (ctrl is Label && ctrl.Name.StartsWith("lblT"))
                    {
                        ctrl.Left = 40;
                        ((Label)ctrl).TextAlign = ContentAlignment.TopLeft;
                    }
                }
            }

            // 3. 【開始遊戲按鈕】水平置中，且定位在規則面板下方一點點
            if (btnStart != null)
            {
                btnStart.Left = (this.ClientSize.Width - btnStart.Width) / 2;

                if (pnlRule != null)
                {
                    btnStart.Top = pnlRule.Bottom + 25;
                }
                else
                {
                    btnStart.Top = 450;
                }
            }
        }

        private void frmStart_Resize(object sender, EventArgs e)
        {
            CenterElements();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.start);
                player.Play();

            }
            catch { }

            Form gameForm = new frmGame();

            // 當 frmGame 被關閉時，連同關閉整個應用程式
            gameForm.FormClosed += (s, args) => this.Close();

            // 隱藏目前的開始介面
            this.Hide();
            gameForm.Show();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            CenterElements();
        }
    }
}
