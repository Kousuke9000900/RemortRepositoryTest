using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // 変数


            // 日付表示
            LabelDateTimeNow.Text = DateTime.Now.ToString("yyyy/MM/dd HH:MM:SS");
            
        }
    }

    
}
