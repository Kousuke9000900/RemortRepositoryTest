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
                sqlConnectionStringBuilder.DataSource = Constant.DATASOURCE;
                sqlConnectionStringBuilder.UserID = Constant.USERID;
                sqlConnectionStringBuilder.Password = Constant.PASSWORD;
                sqlConnectionStringBuilder.InitialCatalog = Constant.INITIALCATALOG;

                // SQL Serverに接続
                Console.WriteLine(Constant.CONNECTIONMESSAGE);
                using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
                {
                    sqlConnection.Open();
                    Console.WriteLine(Constant.SUCCESSMESSAGE);
                }

            } catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
                // エラー用のクラスを作る
                Environment.Exit(0); // 強制終了
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerMaintenance());
        }
    }
}
