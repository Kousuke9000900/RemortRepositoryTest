using System;
using System.Windows.Forms;
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

            // SQL文を実行・結果を貼り付け
            Model.master_customerDAO master_CustomerDAO = new master_customerDAO();                 // インスタンス化
            Model.customer_informationDAO Customer_InformationDAO = new customer_informationDAO();  // インスタンス化
            GridMasterCustomer.DataSource = master_CustomerDAO.Fetchmaster_customer(TextCustomerName.Text,TextBranchName.Text);

            // 結果が無い場合は処理を抜ける
            if (GridMasterCustomer.CurrentCell is null)
            {
                GridCustomerInformation.DataSource = null;
                return;
            }
            String currentCustomerId = GridMasterCustomer.CurrentCell.Value.ToString();             // 文字列に変換
            GridCustomerInformation.DataSource = Customer_InformationDAO.Fetchcustomer_information(currentCustomerId);

        }

        /// <summary>
        /// 現在のセル変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridMasterCustomerSelectionChanged(object sender, EventArgs e)
        {

            // 最初の行以外に遷移した場合は処理を抜ける
            if (GridMasterCustomer.CurrentCell is null)
            {

                return;

            }

            int currentColumnNumber = int.Parse(GridMasterCustomer.CurrentCell.ColumnIndex.ToString());   // 列番号            
            if (currentColumnNumber >= 1)
            {

                return;

            }

            // 取引先情報を更新
            Model.customer_informationDAO Customer_InformationDAO = new customer_informationDAO();  // インスタンス化
            String currentCustomerId = GridMasterCustomer.CurrentCell.Value.ToString();             // 文字列に変換
            GridCustomerInformation.DataSource = Customer_InformationDAO.Fetchcustomer_information(currentCustomerId);

        }

        /// <summary>
        /// 取引先名テキスト入力後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextCustomerNameValidated(object sender, EventArgs e)
        {

            // 特殊文字置換
            TextCustomerName.Text = TextCustomerName.Text.Replace("'", ""); // SQLインジェクション用
            TextCustomerName.Text = TextCustomerName.Text.Replace("%", ""); // 曖昧検索回避

        }

        /// <summary>
        /// 支店名テキスト入力後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBranchName_TextChanged(object sender, EventArgs e)
        {

            // 特殊文字置換
            TextBranchName.Text = TextBranchName.Text.Replace("'", ""); // SQLインジェクション用
            TextBranchName.Text = TextBranchName.Text.Replace("%", ""); // 曖昧検索回避

        }
    }    
}
