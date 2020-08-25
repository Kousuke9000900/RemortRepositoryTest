namespace MaintenanceOfCustomerData
{
    partial class CustomerMaintenance
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
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.TextCustomerName = new System.Windows.Forms.TextBox();
            this.TextBranchName = new System.Windows.Forms.TextBox();
            this.LabelBranchName = new System.Windows.Forms.Label();
            this.GridMasterCustomer = new System.Windows.Forms.DataGridView();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.LabelCustomerInformation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelDateTimeNow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridMasterCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCustomerName.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelCustomerName.Location = new System.Drawing.Point(8, 8);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(91, 21);
            this.LabelCustomerName.TabIndex = 0;
            this.LabelCustomerName.Text = "取引先名";
            // 
            // TextCustomerName
            // 
            this.TextCustomerName.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextCustomerName.Location = new System.Drawing.Point(108, 8);
            this.TextCustomerName.MaxLength = 20;
            this.TextCustomerName.Name = "TextCustomerName";
            this.TextCustomerName.Size = new System.Drawing.Size(288, 22);
            this.TextCustomerName.TabIndex = 1;
            // 
            // TextBranchName
            // 
            this.TextBranchName.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBranchName.Location = new System.Drawing.Point(108, 40);
            this.TextBranchName.MaxLength = 20;
            this.TextBranchName.Name = "TextBranchName";
            this.TextBranchName.Size = new System.Drawing.Size(288, 22);
            this.TextBranchName.TabIndex = 3;
            // 
            // LabelBranchName
            // 
            this.LabelBranchName.AutoSize = true;
            this.LabelBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelBranchName.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelBranchName.Location = new System.Drawing.Point(8, 40);
            this.LabelBranchName.Name = "LabelBranchName";
            this.LabelBranchName.Size = new System.Drawing.Size(71, 21);
            this.LabelBranchName.TabIndex = 2;
            this.LabelBranchName.Text = "支店名";
            // 
            // GridMasterCustomer
            // 
            this.GridMasterCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMasterCustomer.Location = new System.Drawing.Point(8, 72);
            this.GridMasterCustomer.Name = "GridMasterCustomer";
            this.GridMasterCustomer.RowTemplate.Height = 21;
            this.GridMasterCustomer.Size = new System.Drawing.Size(620, 440);
            this.GridMasterCustomer.TabIndex = 4;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(544, 40);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(84, 24);
            this.ButtonSearch.TabIndex = 5;
            this.ButtonSearch.Text = "検索";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // LabelCustomerInformation
            // 
            this.LabelCustomerInformation.AutoSize = true;
            this.LabelCustomerInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCustomerInformation.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelCustomerInformation.Location = new System.Drawing.Point(8, 520);
            this.LabelCustomerInformation.Name = "LabelCustomerInformation";
            this.LabelCustomerInformation.Size = new System.Drawing.Size(111, 21);
            this.LabelCustomerInformation.TabIndex = 6;
            this.LabelCustomerInformation.Text = "取引先情報";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 552);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(620, 260);
            this.dataGridView1.TabIndex = 7;
            // 
            // LabelDateTimeNow
            // 
            this.LabelDateTimeNow.AutoSize = true;
            this.LabelDateTimeNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDateTimeNow.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelDateTimeNow.Location = new System.Drawing.Point(412, 8);
            this.LabelDateTimeNow.Name = "LabelDateTimeNow";
            this.LabelDateTimeNow.Size = new System.Drawing.Size(121, 21);
            this.LabelDateTimeNow.TabIndex = 8;
            this.LabelDateTimeNow.Text = "DateTimeNow";
            // 
            // CustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 821);
            this.Controls.Add(this.LabelDateTimeNow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LabelCustomerInformation);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.GridMasterCustomer);
            this.Controls.Add(this.TextBranchName);
            this.Controls.Add(this.LabelBranchName);
            this.Controls.Add(this.TextCustomerName);
            this.Controls.Add(this.LabelCustomerName);
            this.Name = "CustomerMaintenance";
            this.Text = "取引先マスタ";
            this.Load += new System.EventHandler(this.CustomerMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMasterCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCustomerName;
        private System.Windows.Forms.TextBox TextCustomerName;
        private System.Windows.Forms.TextBox TextBranchName;
        private System.Windows.Forms.Label LabelBranchName;
        private System.Windows.Forms.DataGridView GridMasterCustomer;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label LabelCustomerInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelDateTimeNow;
    }
}

