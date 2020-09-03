using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixWordFile
{
    /// <summary>
    /// 定数用クラス
    /// </summary>
    class ConstantClass
    {
        // 各種定数
        // 定数
        public const string BEFORENAME = "任意の置換したい文字列";
        public const string AFTERNAME = "任意の置換後の文字列";
        public const string FILENAME = "ヘッダーフッター置換リスト.txt";
        public const string BEFORENAMEMESSAGE = "置換したい文字列を入力してください。";
        public const string AFTERNAMEMESSAGE = "置換後の文字列を入力してください。";
        public const string SUCCESSMESSAGE = "置換が完了しました";
        public const string STARTMESSAGE = "カレントディレクトリに置換したいWordファイルを設置してください。準備が完了したらy,終了する場合はy以外のキーを押してください...";
        public const string ERRORMESSAGE = "見つかりませんでした";
        public const string ENDMESSAGE = "任意のキー入力でプログラムを終了します...";
    }
}
