namespace じゃんけんテスト
{
    partial class JyankenTest1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EnemyRock = new System.Windows.Forms.Label();
            this.EnemyPapers = new System.Windows.Forms.Label();
            this.EnemyScissors = new System.Windows.Forms.Label();
            this.MyRock = new System.Windows.Forms.RadioButton();
            this.MyPapers = new System.Windows.Forms.RadioButton();
            this.MyScissors = new System.Windows.Forms.RadioButton();
            this.InfoMessage = new System.Windows.Forms.Label();
            this.SomeButton = new System.Windows.Forms.Button();
            this.TimeInfo = new System.Windows.Forms.Label();
            this.LoseInfo = new System.Windows.Forms.Label();
            this.WinInfo = new System.Windows.Forms.Label();
            this.LoseNumber = new System.Windows.Forms.Label();
            this.WinNumber = new System.Windows.Forms.Label();
            this.Hidden = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurrentTIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnemyRock
            // 
            this.EnemyRock.AutoSize = true;
            this.EnemyRock.Location = new System.Drawing.Point(73, 64);
            this.EnemyRock.Name = "EnemyRock";
            this.EnemyRock.Size = new System.Drawing.Size(24, 12);
            this.EnemyRock.TabIndex = 0;
            this.EnemyRock.Text = "グー";
            // 
            // EnemyPapers
            // 
            this.EnemyPapers.AutoSize = true;
            this.EnemyPapers.Location = new System.Drawing.Point(360, 64);
            this.EnemyPapers.Name = "EnemyPapers";
            this.EnemyPapers.Size = new System.Drawing.Size(25, 12);
            this.EnemyPapers.TabIndex = 1;
            this.EnemyPapers.Text = "パー";
            // 
            // EnemyScissors
            // 
            this.EnemyScissors.AutoSize = true;
            this.EnemyScissors.Location = new System.Drawing.Point(208, 64);
            this.EnemyScissors.Name = "EnemyScissors";
            this.EnemyScissors.Size = new System.Drawing.Size(30, 12);
            this.EnemyScissors.TabIndex = 2;
            this.EnemyScissors.Text = "チョキ";
            // 
            // MyRock
            // 
            this.MyRock.AutoSize = true;
            this.MyRock.Location = new System.Drawing.Point(60, 169);
            this.MyRock.Name = "MyRock";
            this.MyRock.Size = new System.Drawing.Size(42, 16);
            this.MyRock.TabIndex = 6;
            this.MyRock.TabStop = true;
            this.MyRock.Text = "グー";
            this.MyRock.UseVisualStyleBackColor = true;
            // 
            // MyPapers
            // 
            this.MyPapers.AutoSize = true;
            this.MyPapers.Location = new System.Drawing.Point(362, 169);
            this.MyPapers.Name = "MyPapers";
            this.MyPapers.Size = new System.Drawing.Size(43, 16);
            this.MyPapers.TabIndex = 7;
            this.MyPapers.TabStop = true;
            this.MyPapers.Text = "パー";
            this.MyPapers.UseVisualStyleBackColor = true;
            // 
            // MyScissors
            // 
            this.MyScissors.AutoSize = true;
            this.MyScissors.Location = new System.Drawing.Point(210, 169);
            this.MyScissors.Name = "MyScissors";
            this.MyScissors.Size = new System.Drawing.Size(48, 16);
            this.MyScissors.TabIndex = 8;
            this.MyScissors.TabStop = true;
            this.MyScissors.Text = "チョキ";
            this.MyScissors.UseVisualStyleBackColor = true;
            // 
            // InfoMessage
            // 
            this.InfoMessage.AutoSize = true;
            this.InfoMessage.Location = new System.Drawing.Point(191, 23);
            this.InfoMessage.Name = "InfoMessage";
            this.InfoMessage.Size = new System.Drawing.Size(101, 12);
            this.InfoMessage.TabIndex = 9;
            this.InfoMessage.Text = "情報が表示されます";
            // 
            // SomeButton
            // 
            this.SomeButton.Location = new System.Drawing.Point(399, 223);
            this.SomeButton.Name = "SomeButton";
            this.SomeButton.Size = new System.Drawing.Size(75, 23);
            this.SomeButton.TabIndex = 10;
            this.SomeButton.Text = "多機能ボタン";
            this.SomeButton.UseVisualStyleBackColor = true;
            this.SomeButton.Click += new System.EventHandler(this.SomeButton_Click);
            // 
            // TimeInfo
            // 
            this.TimeInfo.AutoSize = true;
            this.TimeInfo.Location = new System.Drawing.Point(127, 115);
            this.TimeInfo.Name = "TimeInfo";
            this.TimeInfo.Size = new System.Drawing.Size(49, 12);
            this.TimeInfo.TabIndex = 11;
            this.TimeInfo.Text = "残り時間";
            // 
            // LoseInfo
            // 
            this.LoseInfo.AutoSize = true;
            this.LoseInfo.Location = new System.Drawing.Point(423, 38);
            this.LoseInfo.Name = "LoseInfo";
            this.LoseInfo.Size = new System.Drawing.Size(27, 12);
            this.LoseInfo.TabIndex = 13;
            this.LoseInfo.Text = "負け";
            // 
            // WinInfo
            // 
            this.WinInfo.AutoSize = true;
            this.WinInfo.Location = new System.Drawing.Point(423, 9);
            this.WinInfo.Name = "WinInfo";
            this.WinInfo.Size = new System.Drawing.Size(26, 12);
            this.WinInfo.TabIndex = 14;
            this.WinInfo.Text = "勝ち";
            // 
            // LoseNumber
            // 
            this.LoseNumber.AutoSize = true;
            this.LoseNumber.Location = new System.Drawing.Point(456, 38);
            this.LoseNumber.Name = "LoseNumber";
            this.LoseNumber.Size = new System.Drawing.Size(11, 12);
            this.LoseNumber.TabIndex = 15;
            this.LoseNumber.Text = "0";
            // 
            // WinNumber
            // 
            this.WinNumber.AutoSize = true;
            this.WinNumber.Location = new System.Drawing.Point(455, 9);
            this.WinNumber.Name = "WinNumber";
            this.WinNumber.Size = new System.Drawing.Size(11, 12);
            this.WinNumber.TabIndex = 16;
            this.WinNumber.Text = "0";
            // 
            // Hidden
            // 
            this.Hidden.AutoSize = true;
            this.Hidden.Location = new System.Drawing.Point(60, 210);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(65, 16);
            this.Hidden.TabIndex = 17;
            this.Hidden.TabStop = true;
            this.Hidden.Text = "グッチッパ";
            this.Hidden.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CurrentTIme
            // 
            this.CurrentTIme.AutoSize = true;
            this.CurrentTIme.Location = new System.Drawing.Point(208, 115);
            this.CurrentTIme.Name = "CurrentTIme";
            this.CurrentTIme.Size = new System.Drawing.Size(29, 12);
            this.CurrentTIme.TabIndex = 12;
            this.CurrentTIme.Text = "数字";
            // 
            // JyankenTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 258);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.WinNumber);
            this.Controls.Add(this.LoseNumber);
            this.Controls.Add(this.WinInfo);
            this.Controls.Add(this.LoseInfo);
            this.Controls.Add(this.CurrentTIme);
            this.Controls.Add(this.TimeInfo);
            this.Controls.Add(this.SomeButton);
            this.Controls.Add(this.InfoMessage);
            this.Controls.Add(this.MyScissors);
            this.Controls.Add(this.MyPapers);
            this.Controls.Add(this.MyRock);
            this.Controls.Add(this.EnemyScissors);
            this.Controls.Add(this.EnemyPapers);
            this.Controls.Add(this.EnemyRock);
            this.Name = "JyankenTest1";
            this.Text = "じゃんけん";
            this.Load += new System.EventHandler(this.JyankenTest1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnemyRock;
        private System.Windows.Forms.Label EnemyPapers;
        private System.Windows.Forms.Label EnemyScissors;
        private System.Windows.Forms.RadioButton MyRock;
        private System.Windows.Forms.RadioButton MyPapers;
        private System.Windows.Forms.RadioButton MyScissors;
        private System.Windows.Forms.Label InfoMessage;
        private System.Windows.Forms.Button SomeButton;
        private System.Windows.Forms.Label TimeInfo;
        private System.Windows.Forms.Label LoseInfo;
        private System.Windows.Forms.Label WinInfo;
        private System.Windows.Forms.Label LoseNumber;
        private System.Windows.Forms.Label WinNumber;
        private System.Windows.Forms.RadioButton Hidden;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CurrentTIme;
    }
}

