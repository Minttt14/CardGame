namespace 棋牌類遊戲
{
    partial class frmGame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnAsk = new System.Windows.Forms.Button();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.flpCard = new System.Windows.Forms.FlowLayoutPanel();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.lblStatus_P = new System.Windows.Forms.Label();
            this.lblCB = new System.Windows.Forms.Label();
            this.pnlCB = new System.Windows.Forms.Panel();
            this.lblStatus_B = new System.Windows.Forms.Label();
            this.picCB = new System.Windows.Forms.PictureBox();
            this.lblCA = new System.Windows.Forms.Label();
            this.pnlCA = new System.Windows.Forms.Panel();
            this.lblStatus_A = new System.Windows.Forms.Label();
            this.picCA = new System.Windows.Forms.PictureBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.pnlCC = new System.Windows.Forms.Panel();
            this.lblStatus_C = new System.Windows.Forms.Label();
            this.picCC = new System.Windows.Forms.PictureBox();
            this.lblRemain = new System.Windows.Forms.Label();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.pnlPublic = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cmbMusic = new System.Windows.Forms.ComboBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.picPublic = new System.Windows.Forms.PictureBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnRule = new System.Windows.Forms.Button();
            this.pnlPlayer.SuspendLayout();
            this.flpCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.pnlCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCB)).BeginInit();
            this.pnlCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCA)).BeginInit();
            this.pnlCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCC)).BeginInit();
            this.pnlPublic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPublic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer.Location = new System.Drawing.Point(33, 21);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(168, 47);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "【玩家】";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAsk
            // 
            this.btnAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.btnAsk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(32)))));
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(16)))));
            this.btnAsk.Location = new System.Drawing.Point(1191, 78);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(140, 63);
            this.btnAsk.TabIndex = 5;
            this.btnAsk.Text = "詢問";
            this.btnAsk.UseVisualStyleBackColor = false;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.pnlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayer.Controls.Add(this.flpCard);
            this.pnlPlayer.Controls.Add(this.lblStatus_P);
            this.pnlPlayer.Controls.Add(this.btnAsk);
            this.pnlPlayer.Controls.Add(this.lblPlayer);
            this.pnlPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlayer.Location = new System.Drawing.Point(0, 609);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(1420, 218);
            this.pnlPlayer.TabIndex = 10;
            // 
            // flpCard
            // 
            this.flpCard.AutoScroll = true;
            this.flpCard.BackColor = System.Drawing.Color.Transparent;
            this.flpCard.Controls.Add(this.pic3);
            this.flpCard.Controls.Add(this.pic1);
            this.flpCard.Controls.Add(this.pic4);
            this.flpCard.Controls.Add(this.pic2);
            this.flpCard.Controls.Add(this.pic5);
            this.flpCard.Location = new System.Drawing.Point(226, 37);
            this.flpCard.Name = "flpCard";
            this.flpCard.Size = new System.Drawing.Size(574, 168);
            this.flpCard.TabIndex = 8;
            this.flpCard.WrapContents = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.pic3.Location = new System.Drawing.Point(3, 3);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(89, 137);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 10;
            this.pic3.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.pic1.Location = new System.Drawing.Point(98, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(89, 137);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 8;
            this.pic1.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.pic4.Location = new System.Drawing.Point(193, 3);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(89, 137);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 11;
            this.pic4.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.pic2.Location = new System.Drawing.Point(288, 3);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(89, 137);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 9;
            this.pic2.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.pic5.Location = new System.Drawing.Point(383, 3);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(89, 137);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 12;
            this.pic5.TabStop = false;
            // 
            // lblStatus_P
            // 
            this.lblStatus_P.AutoSize = true;
            this.lblStatus_P.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus_P.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus_P.Location = new System.Drawing.Point(1150, 20);
            this.lblStatus_P.Name = "lblStatus_P";
            this.lblStatus_P.Size = new System.Drawing.Size(218, 35);
            this.lblStatus_P.TabIndex = 7;
            this.lblStatus_P.Text = "手牌：0  |  書：0";
            this.lblStatus_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCB.Location = new System.Drawing.Point(497, 9);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(192, 47);
            this.lblCB.TabIndex = 4;
            this.lblCB.Text = "【電腦B】";
            this.lblCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCB
            // 
            this.pnlCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(38)))));
            this.pnlCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCB.Controls.Add(this.btnRule);
            this.pnlCB.Controls.Add(this.lblStatus_B);
            this.pnlCB.Controls.Add(this.picCB);
            this.pnlCB.Controls.Add(this.lblCB);
            this.pnlCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCB.Location = new System.Drawing.Point(0, 0);
            this.pnlCB.Name = "pnlCB";
            this.pnlCB.Size = new System.Drawing.Size(1420, 179);
            this.pnlCB.TabIndex = 11;
            // 
            // lblStatus_B
            // 
            this.lblStatus_B.AutoSize = true;
            this.lblStatus_B.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus_B.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus_B.Location = new System.Drawing.Point(482, 66);
            this.lblStatus_B.Name = "lblStatus_B";
            this.lblStatus_B.Size = new System.Drawing.Size(218, 35);
            this.lblStatus_B.TabIndex = 16;
            this.lblStatus_B.Text = "手牌：0  |  書：0";
            this.lblStatus_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCB
            // 
            this.picCB.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.picCB.Location = new System.Drawing.Point(184, 11);
            this.picCB.Name = "picCB";
            this.picCB.Size = new System.Drawing.Size(88, 128);
            this.picCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCB.TabIndex = 7;
            this.picCB.TabStop = false;
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCA.Location = new System.Drawing.Point(29, 16);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(195, 47);
            this.lblCA.TabIndex = 3;
            this.lblCA.Text = "【電腦A】";
            this.lblCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCA
            // 
            this.pnlCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(38)))));
            this.pnlCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCA.Controls.Add(this.lblStatus_A);
            this.pnlCA.Controls.Add(this.picCA);
            this.pnlCA.Controls.Add(this.lblCA);
            this.pnlCA.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCA.Location = new System.Drawing.Point(1183, 179);
            this.pnlCA.Name = "pnlCA";
            this.pnlCA.Size = new System.Drawing.Size(237, 430);
            this.pnlCA.TabIndex = 12;
            // 
            // lblStatus_A
            // 
            this.lblStatus_A.AutoSize = true;
            this.lblStatus_A.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus_A.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus_A.Location = new System.Drawing.Point(14, 75);
            this.lblStatus_A.Name = "lblStatus_A";
            this.lblStatus_A.Size = new System.Drawing.Size(218, 35);
            this.lblStatus_A.TabIndex = 15;
            this.lblStatus_A.Text = "手牌：0  |  書：0";
            this.lblStatus_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCA
            // 
            this.picCA.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.picCA.Location = new System.Drawing.Point(35, 137);
            this.picCA.Name = "picCA";
            this.picCA.Size = new System.Drawing.Size(128, 88);
            this.picCA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCA.TabIndex = 6;
            this.picCA.TabStop = false;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCC.Location = new System.Drawing.Point(12, 23);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(193, 47);
            this.lblCC.TabIndex = 5;
            this.lblCC.Text = "【電腦C】";
            this.lblCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCC
            // 
            this.pnlCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(38)))));
            this.pnlCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCC.Controls.Add(this.lblStatus_C);
            this.pnlCC.Controls.Add(this.picCC);
            this.pnlCC.Controls.Add(this.lblCC);
            this.pnlCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCC.Location = new System.Drawing.Point(0, 179);
            this.pnlCC.Name = "pnlCC";
            this.pnlCC.Size = new System.Drawing.Size(227, 430);
            this.pnlCC.TabIndex = 13;
            // 
            // lblStatus_C
            // 
            this.lblStatus_C.AutoSize = true;
            this.lblStatus_C.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus_C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus_C.Location = new System.Drawing.Point(12, 75);
            this.lblStatus_C.Name = "lblStatus_C";
            this.lblStatus_C.Size = new System.Drawing.Size(218, 35);
            this.lblStatus_C.TabIndex = 6;
            this.lblStatus_C.Text = "手牌：0  |  書：0";
            this.lblStatus_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCC
            // 
            this.picCC.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.picCC.Location = new System.Drawing.Point(30, 137);
            this.picCC.Name = "picCC";
            this.picCC.Size = new System.Drawing.Size(128, 88);
            this.picCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCC.TabIndex = 3;
            this.picCC.TabStop = false;
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRemain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(122)))), ((int)(((byte)(80)))));
            this.lblRemain.Location = new System.Drawing.Point(267, 39);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(291, 55);
            this.lblRemain.TabIndex = 1;
            this.lblRemain.Text = "剩餘牌數：32";
            // 
            // lstInfo
            // 
            this.lstInfo.BackColor = System.Drawing.Color.White;
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstInfo.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 47;
            this.lstInfo.Location = new System.Drawing.Point(107, 220);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(808, 143);
            this.lstInfo.TabIndex = 2;
            // 
            // pnlPublic
            // 
            this.pnlPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            this.pnlPublic.Controls.Add(this.lblChoice);
            this.pnlPublic.Controls.Add(this.btnStop);
            this.pnlPublic.Controls.Add(this.btnPlay);
            this.pnlPublic.Controls.Add(this.cmbMusic);
            this.pnlPublic.Controls.Add(this.btnRestart);
            this.pnlPublic.Controls.Add(this.picPublic);
            this.pnlPublic.Controls.Add(this.lstInfo);
            this.pnlPublic.Controls.Add(this.lblRemain);
            this.pnlPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPublic.Location = new System.Drawing.Point(227, 179);
            this.pnlPublic.Name = "pnlPublic";
            this.pnlPublic.Size = new System.Drawing.Size(956, 430);
            this.pnlPublic.TabIndex = 14;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightGray;
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(757, 109);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(158, 48);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "停止播放";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightGray;
            this.btnPlay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlay.Location = new System.Drawing.Point(757, 41);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(158, 48);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "開始播放";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cmbMusic
            // 
            this.cmbMusic.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMusic.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmbMusic.FormattingEnabled = true;
            this.cmbMusic.Items.AddRange(new object[] {
            "music1",
            "music2",
            "music3"});
            this.cmbMusic.Location = new System.Drawing.Point(573, 99);
            this.cmbMusic.Name = "cmbMusic";
            this.cmbMusic.Size = new System.Drawing.Size(168, 48);
            this.cmbMusic.TabIndex = 10;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightGray;
            this.btnRestart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestart.Location = new System.Drawing.Point(301, 109);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(208, 57);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "重新開始";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picPublic
            // 
            this.picPublic.Image = global::棋牌類遊戲.Properties.Resources.back;
            this.picPublic.Location = new System.Drawing.Point(107, 24);
            this.picPublic.Name = "picPublic";
            this.picPublic.Size = new System.Drawing.Size(133, 174);
            this.picPublic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPublic.TabIndex = 8;
            this.picPublic.TabStop = false;
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            this.lblChoice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(151)))));
            this.lblChoice.Location = new System.Drawing.Point(582, 46);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(145, 40);
            this.lblChoice.TabIndex = 13;
            this.lblChoice.Text = "選擇音樂";
            // 
            // btnRule
            // 
            this.btnRule.BackColor = System.Drawing.Color.SlateGray;
            this.btnRule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(32)))));
            this.btnRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRule.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRule.Location = new System.Drawing.Point(1134, 38);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(197, 63);
            this.btnRule.TabIndex = 9;
            this.btnRule.Text = "遊戲規則";
            this.btnRule.UseVisualStyleBackColor = false;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 827);
            this.Controls.Add(this.pnlPublic);
            this.Controls.Add(this.pnlCC);
            this.Controls.Add(this.pnlCA);
            this.Controls.Add(this.pnlCB);
            this.Controls.Add(this.pnlPlayer);
            this.DoubleBuffered = true;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "撲克牌遊戲: 一本書";
            this.Resize += new System.EventHandler(this.frmGame_Resize);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.flpCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.pnlCB.ResumeLayout(false);
            this.pnlCB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCB)).EndInit();
            this.pnlCA.ResumeLayout(false);
            this.pnlCA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCA)).EndInit();
            this.pnlCC.ResumeLayout(false);
            this.pnlCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCC)).EndInit();
            this.pnlPublic.ResumeLayout(false);
            this.pnlPublic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPublic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.PictureBox picCB;
        private System.Windows.Forms.Panel pnlCB;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.PictureBox picCA;
        private System.Windows.Forms.Panel pnlCA;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.PictureBox picCC;
        private System.Windows.Forms.Panel pnlCC;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.PictureBox picPublic;
        private System.Windows.Forms.Panel pnlPublic;
        private System.Windows.Forms.Label lblStatus_P;
        private System.Windows.Forms.Label lblStatus_B;
        private System.Windows.Forms.Label lblStatus_A;
        private System.Windows.Forms.Label lblStatus_C;
        private System.Windows.Forms.FlowLayoutPanel flpCard;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ComboBox cmbMusic;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnRule;
    }
}

