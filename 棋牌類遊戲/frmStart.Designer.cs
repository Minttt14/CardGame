namespace 棋牌類遊戲
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRule = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT4 = new System.Windows.Forms.Label();
            this.lblT5 = new System.Windows.Forms.Label();
            this.lblT6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(309, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(519, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "撲克牌遊戲： 一本書";
            // 
            // pnlRule
            // 
            this.pnlRule.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRule.Controls.Add(this.lblT6);
            this.pnlRule.Controls.Add(this.lblT5);
            this.pnlRule.Controls.Add(this.lblT4);
            this.pnlRule.Controls.Add(this.lblT3);
            this.pnlRule.Controls.Add(this.lblT2);
            this.pnlRule.Controls.Add(this.lblT1);
            this.pnlRule.Controls.Add(this.lblHead);
            this.pnlRule.Location = new System.Drawing.Point(80, 123);
            this.pnlRule.Name = "pnlRule";
            this.pnlRule.Size = new System.Drawing.Size(999, 566);
            this.pnlRule.TabIndex = 2;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHead.ForeColor = System.Drawing.Color.DimGray;
            this.lblHead.Location = new System.Drawing.Point(272, 27);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(432, 54);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "【 遊戲規則與流程 】";
            // 
            // lblT1
            // 
            this.lblT1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblT1.ForeColor = System.Drawing.Color.DimGray;
            this.lblT1.Location = new System.Drawing.Point(57, 127);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(734, 54);
            this.lblT1.TabIndex = 4;
            this.lblT1.Text = "1. 回合順序：玩家 ➔ 電腦A ➔ 電腦B ➔ 電腦C";
            // 
            // lblT2
            // 
            this.lblT2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblT2.ForeColor = System.Drawing.Color.DimGray;
            this.lblT2.Location = new System.Drawing.Point(57, 190);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(932, 57);
            this.lblT2.TabIndex = 5;
            this.lblT2.Text = "2. 輪到自己時，選擇一張手牌並詢問所有對手是否有相同數字";
            // 
            // lblT3
            // 
            this.lblT3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblT3.ForeColor = System.Drawing.Color.DimGray;
            this.lblT3.Location = new System.Drawing.Point(57, 250);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(734, 63);
            this.lblT3.TabIndex = 6;
            this.lblT3.Text = "3. 若對手有該數字，拿走卡牌並切換到下一位玩家";
            // 
            // lblT4
            // 
            this.lblT4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblT4.ForeColor = System.Drawing.Color.DimGray;
            this.lblT4.Location = new System.Drawing.Point(57, 307);
            this.lblT4.Name = "lblT4";
            this.lblT4.Size = new System.Drawing.Size(734, 50);
            this.lblT4.TabIndex = 7;
            this.lblT4.Text = "4. 若對手皆無此牌，系統會自動從中央抽取一張牌";
            // 
            // lblT5
            // 
            this.lblT5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblT5.ForeColor = System.Drawing.Color.DimGray;
            this.lblT5.Location = new System.Drawing.Point(57, 369);
            this.lblT5.Name = "lblT5";
            this.lblT5.Size = new System.Drawing.Size(734, 51);
            this.lblT5.TabIndex = 8;
            this.lblT5.Text = "5. 湊齊 4 張同數字卡牌即完成「一本書」並得分";
            // 
            // lblT6
            // 
            this.lblT6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblT6.ForeColor = System.Drawing.Color.DimGray;
            this.lblT6.Location = new System.Drawing.Point(57, 432);
            this.lblT6.Name = "lblT6";
            this.lblT6.Size = new System.Drawing.Size(734, 89);
            this.lblT6.TabIndex = 9;
            this.lblT6.Text = "6. 重複此流程直到所有牌都被組成書，擁有最多本書的玩家獲勝";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(348, 710);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(468, 87);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "開始遊戲";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1162, 809);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlRule);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "開始介面";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.Resize += new System.EventHandler(this.frmStart_Resize);
            this.pnlRule.ResumeLayout(false);
            this.pnlRule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRule;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT4;
        private System.Windows.Forms.Label lblT5;
        private System.Windows.Forms.Label lblT6;
        private System.Windows.Forms.Button btnStart;
    }
}