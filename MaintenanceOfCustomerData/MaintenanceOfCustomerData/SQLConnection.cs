using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaintenanceOfCustomerData.Model
{
    /// <summary>
    /// SQLServerと接続し、SqlConncetionクラスを返すクラス
    /// </summary>
    class SQLConnection
    {
        /// <summary>
        /// SQLServerに接続
        /// </summary>
        /// <return>SqlConnectionクラス</return>
        /// <remarks>Model内で共通するメソッドなので静的メソッドとして定義</remarks>
        public static SqlConnection ConnectToSQLServer()
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
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                sqlConnection.Open();
                Console.WriteLine(Constant.SUCCESSMESSAGE);
                return sqlConnection;

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(Constant.SQLEXCEPTIONMESSAGE, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
