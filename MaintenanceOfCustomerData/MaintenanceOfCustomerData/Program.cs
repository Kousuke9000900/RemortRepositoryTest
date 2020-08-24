using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaintenanceOfCustomerData
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                // 接続文字列の構築
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();

                sqlConnectionStringBuilder.DataSource = Constant

            } catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("SQL Serverへの接続が成功しました。");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerMaintenance());
        }
    }
}
