using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MaintenanceOfCustomerData.Model
{
    public class master_customerDAO
    {
        /// <summary>
        /// master_customerからデータを取り出す
        /// </summary>
        /// <param>textCustomerName:画面内に入力された取引先名 textBranchName:画面内に入力された支店名</param>
        /// <returns>dataOfmaster_customer:検索結果を格納したデータ</returns>
        /// <remarks>master_customerテーブルからデータを取り出す際に使用</remarks>
        public DataTable Fetchmaster_customer(String textCustomerName, String textBranchName)
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
                    SQLQuery = SQLQuery.Replace("{0}", textCustomerName);   // 取引先名
                    SQLQuery = SQLQuery.Replace("{1}", textBranchName);     // 支店名
                    command.CommandText = SQLQuery;

                    // SQL文を実行
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataOfmaster_customer);

                } catch (FileNotFoundException e) {

                    Console.WriteLine(e.Message);
                    MessageBox.Show(Constant.FILENOTFOUNDEXCEPTIONMESSAGE,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return null;

                } finally {

                    // データベースの接続終了
                    sqlConnection.Close();
                }

            }

            return dataOfmaster_customer;
        }
    }
}
