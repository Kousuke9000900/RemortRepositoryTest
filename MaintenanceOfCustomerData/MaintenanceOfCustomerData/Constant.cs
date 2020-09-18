namespace MaintenanceOfCustomerData
{
    /// <summary>
    /// 定数用クラス
    /// </summary>
    static class Constant
    {
        // SQL Serverの接続文字列用
        public const string DATASOURCE = "任意のインスタンス名";    // インスタンス名
        public const string USERID = "任意のユーザーID";         // ログインユーザーID
        public const string PASSWORD = "任意のログインパスワード";    // ログインパスワード
        public const string INITIALCATALOG = "任意のデータベース";  // 使用データベース

        // SQL Serverの接続メッセージ
        public const string CONNECTIONMESSAGE = "SQL Serverに接続しています...";
        public const string SUCCESSMESSAGE = "SQL Serverへの接続に成功しました。";
        public const string FAILUREMESSAGE = "SQL Serverへの接続に失敗しました。";

        // 各種エラーメッセージ
        public const string FILENOTFOUNDEXCEPTIONMESSAGE = "ファイルが見つかりません。";
        public const string SQLEXCEPTIONMESSAGE = "SQL Serverでエラーが発生しました。アプリケーションを終了します。";

    }
}
