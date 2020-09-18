using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MaintenanceOfCustomerData.Model
{
    class customer_informationDAO
    {

        /// <summary>
        /// customer_informationからデータを取り出す
        /// <param>customerId:取引先ID（条件句）</param>
        /// <returns>dataOfmaster_customer:検索結果を格納したデータ</returns>
        /// </summary>
        public DataTable Fetchcustomer_information(string customerId)
        {

            // データテーブル
            DataTable dataOfmaster_customer = new DataTable();

            // SQLServerに接続する（接続失敗時、強制終了）
            SqlConnection sqlConnection = SQLConnection.ConnectToSQLServer();
            if (sqlConnection is null)
            {
                Environment.Exit(0);
            }

            // SQL文を実行し、DataTableに格納
            using (var command = sqlConnection.CreateCommand())
            {
                try
                {
                    // SQL文の読み取り
                    StreamReader streamReader = new StreamReader(@"任意のSQLファイルパス", Encoding.GetEncoding("UTF-8"));
                    String SQLQuery = streamReader.ReadToEnd();

                    // SQL文を設定
                    SQLQuery = SQLQuery.Replace("{0}", customerId);   // 取引先ID
                    command.CommandText = SQLQuery;

                    // SQL文を実行
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataOfmaster_customer);

                }
                catch (FileNotFoundException e)
                {

                    Console.WriteLine(e.Message);
                    MessageBox.Show(Constant.FILENOTFOUNDEXCEPTIONMESSAGE, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;

                }
                finally
                {

                    // データベースの接続終了
                    sqlConnection.Close();
                }

            }

            return dataOfmaster_customer;

        }

    }
}
