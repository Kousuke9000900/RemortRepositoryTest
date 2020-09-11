using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace MaintenanceOfCustomerData.Model
{
    public class DAO
    {
        /// <summary>
        /// SQLServerに接続
        /// </summary>
        /// <remarks>DAOクラス内でメソッドを定義する際に使用</remarks>
        private static void ConnectToSQLServer()
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
                using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
                {
                    sqlConnection.Open();
                    Console.WriteLine(Constant.SUCCESSMESSAGE);
                }

            } catch(SqlException e) {
                Console.WriteLine(e.ToString());
                // エラー用のクラスを作る→例外をスローして処理する用のクラス？
                Environment.Exit(0); // 強制終了
            }
        }

        /// <summary>
        /// master_customerからデータを取り出す
        /// </summary>
        /// <returns>FetchedData:検索結果を格納したデータ</returns>
        public static DataTable Fetchmaster_customer(String SQLParameter)
        {
            // 変数
            DataTable dataTable = null;

            // SQLServerに接続する
            ConnectToSQLServer();

            // SQL文の読み取り
            StreamReader streamReader = new StreamReader(@"SQLファイルパス", Encoding.GetEncoding("UTF-8"));
            String SQLQuery = streamReader.ReadToEnd();
            Console.WriteLine(SQLQuery);

            // 条件句を置換


            // SQL文を実行し、DataTableに格納

            return dataTable;

        }
    }
}
