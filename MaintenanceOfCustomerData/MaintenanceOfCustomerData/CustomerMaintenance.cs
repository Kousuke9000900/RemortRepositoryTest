using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MaintenanceOfCustomerData.Model;

namespace MaintenanceOfCustomerData
{
    public partial class CustomerMaintenance : Form
    {
        public CustomerMaintenance()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerMaintenance_Load(object sender, EventArgs e)
        {
            // 日付表示
            LabelDateTimeNow.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            
        }

        /// <summary>
        /// 検索ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchClick(object sender, EventArgs e)
        {
            // エラーが無いかチェック(文字数制限、バイト数制限)

            // SQL文を実行・結果を貼り付け
            Model.master_customerDAO master_CustomerDAO = new master_customerDAO();
            GridMasterCustomer.DataSource = master_CustomerDAO.Fetchmaster_customer(TextCustomerName.Text,TextBranchName.Text);

        }

        ///// <summary>
        ///// 入力項目にエラーが無いか確認する
        ///// 確認項目:入力された文字列の合計バイト数（40バイト以内）
        ///// </summary>
        ///// <returns></returns>
        //private Boolean ValidateAnyError()
        //{

        //}
    }

    
}
