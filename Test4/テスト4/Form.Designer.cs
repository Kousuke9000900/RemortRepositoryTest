namespace テスト4
{
    partial class Form
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBullet = new System.Windows.Forms.PictureBox();
            this.retryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBullet)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Yellow;
            this.Player.Location = new System.Drawing.Point(30, 188);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(29, 26);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.SkyBlue;
            this.Enemy.Location = new System.Drawing.Point(709, 188);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(29, 26);
            this.Enemy.TabIndex = 1;
            this.Enemy.TabStop = false;
            // 
            // Bullet
            // 
            this.Bullet.BackColor = System.Drawing.Color.White;
            this.Bullet.Location = new System.Drawing.Point(65, 188);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(17, 15);
            this.Bullet.TabIndex = 2;
            this.Bullet.TabStop = false;
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 1;
            this.myTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EnemyBullet
            // 
            this.EnemyBullet.BackColor = System.Drawing.Color.White;
            this.EnemyBullet.Location = new System.Drawing.Point(673, 199);
            this.EnemyBullet.Name = "EnemyBullet";
            this.EnemyBullet.Size = new System.Drawing.Size(17, 15);
            this.EnemyBullet.TabIndex = 3;
            this.EnemyBullet.TabStop = false;
            // 
            // retryButton
            // 
            this.retryButton.Location = new System.Drawing.Point(339, 393);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(75, 23);
            this.retryButton.TabIndex = 4;
            this.retryButton.Text = "リトライ";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.EnemyBullet);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Player);
            this.Name = "Main";
            this.Text = "Shooting";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBullet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.PictureBox EnemyBullet;
        private System.Windows.Forms.Button retryButton;
    }
}

