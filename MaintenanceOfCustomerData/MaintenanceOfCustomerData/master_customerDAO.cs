using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MaintenanceOfCustomerData.Model
{
    public class master_customerDAO
    {
        /// <summary>
        /// SQLServerに接続
        /// </summary>
        /// <return>SqlConnectionクラス</return>
        /// <remarks>DAOクラス内でデータベースに接続する際に使用</remarks>
        private SqlConnection ConnectToSQLServer()
        {
            try{
                // 接続文字列の構築
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
                sqlConnectionStringBuilder.DataSource = Constant.DATASOURCE;
                sqlConnectionStringBuilder.UserID = Constant.USERID;
                sqlConnectionStringBuilder.Password = Constant.PASSWORD;
                sqlConnectionStringBuilder.InitialCatalog = Constant.INITIALCATALOG;

                // SQL Serverに接続
                Console.WriteLine(Constant.CONNECTIONMESSAGE);
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                sqlConnection.Open();
                Console.WriteLine(Constant.SUCCESSMESSAGE);
                return sqlConnection;

            } catch(SqlException e) {
                Console.WriteLine(e.ToString());
                MessageBox.Show(Constant.SQLEXCEPTIONMESSAGE, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// master_customerからデータを取り出す
        /// </summary>
        /// <param>textCustomerName:画面内に入力された取引先名 textBranchName:画面内に入力された支店名</param>
        /// <returns>FetchedData:検索結果を格納したデータ</returns>
        /// <remarks>master_customerテーブルからデータを取り出す際に使用</remarks>
        public DataTable Fetchmaster_customer(String textCustomerName, String textBranchName)
        {
            // データテーブル
            DataTable dataTable = new DataTable();

            // SQLServerに接続する
            SqlConnection sqlConnection = ConnectToSQLServer();
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
                    StreamReader streamReader = new StreamReader(@"SQLファイルの絶対パス", Encoding.GetEncoding("UTF-8"));
                    String SQLQuery = streamReader.ReadToEnd();

                    // SQL文を設定
                    SQLQuery = SQLQuery.Replace("{0}", textCustomerName);   // 取引先名
                    SQLQuery = SQLQuery.Replace("{1}", textBranchName);     // 支店名
                    command.CommandText = SQLQuery;

                    // SQL文を実行
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                } catch (FileNotFoundException ex) {

                    Console.WriteLine(ex.Message);
                    MessageBox.Show(Constant.FILENOTFOUNDEXCEPTIONMESSAGE,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return null;

                } finally {
                    // データベースの接続終了
                    sqlConnection.Close();
                }

            }

            return dataTable;
        }
    }
}
