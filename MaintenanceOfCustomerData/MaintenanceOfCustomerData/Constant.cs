namespace MaintenanceOfCustomerData
{
    /// <summary>
    /// 定数用クラス
    /// </summary>
    static class Constant
    {
        // SQL Serverの接続文字列用
        public const string DATASOURCE = "ITS177\\FORSTUDY";    // インスタンス名
        public const string USERID = "manager";         // ログインユーザーID
        public const string PASSWORD = "supervisor";    // ログインパスワード
        public const string INITIALCATALOG = "system_data";  // 使用データベース

        // SQL Serverの接続メッセージ
        public const string CONNECTIONMESSAGE = "SQL Serverに接続しています...";
        public const string SUCCESSMESSAGE = "SQL Serverへの接続に成功しました。";
        public const string FAILUREMESSAGE = "SQL Serverへの接続に失敗しました。";
    }
}
