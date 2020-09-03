using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace FixWordFile
{
    class Program
    {

        static void Main(string[] args)
        {

            // 事前確認
            Console.WriteLine(ConstantClass.STARTMESSAGE);
            String ReadKey =  Console.ReadLine();
            if (!ReadKey.Equals("y"))
            {
                Environment.Exit(0);    // 終了
            }

            // 置換したい文字列・置換後の文字列を確認
            Console.WriteLine(ConstantClass.BEFORENAMEMESSAGE);
            String BeforeName = Console.ReadLine();
            Console.WriteLine(ConstantClass.AFTERNAMEMESSAGE);
            String AfterName = Console.ReadLine();            

            // 破損ファイルが存在する場合、削除
            List<String> BeforeFileNames = new List<string>();
            BeforeFileNames.AddRange(Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), "*.doc"));
            Console.WriteLine(BeforeFileNames[0]);    // ファイル名確認
            foreach (string FileName in BeforeFileNames)
            {
                if (FileName.Contains("~$"))
                {
                    File.Delete(FileName);
                }
            }
            BeforeFileNames = null;

            // ファイルを取得、クラスを初期化
            List<String> FileNames = new List<string>();
            FileNames.AddRange(Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), "*.doc"));
            Microsoft.Office.Interop.Word.Application application = null;
            Encoding ShiftJis = Encoding.GetEncoding("Shift_JIS");
            Word.Document document = null;

            // 置換→保存→閉じる（例外時は保存しない）
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ConstantClass.FILENAME, false, ShiftJis))  // 書き込む毎に上書き保存
                {
                    foreach (string FileName in FileNames)
                    {
                        application = new Microsoft.Office.Interop.Word.Application();
                        application.Visible = false;
                        document = application.Documents.Open(FileName);    // Wordファイルを開く
                        Word.Sections sections = document.Sections;         // 現在開いているWordファイルのSectionsオブジェクト
                        Section section = sections[1];
                        String FileNamePath = System.IO.Path.GetDirectoryName(FileName);
                        String FileNameOnly = System.IO.Path.GetFileName(FileName);
                        streamWriter.WriteLine("");
                        streamWriter.Write(FileNamePath + ",");
                        streamWriter.Write(FileNameOnly + ",");
                        Console.WriteLine(FileName + "を開きました");

                        // ヘッダー
                        Range HeaderRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;   // ヘッダー情報
                        String HeaderText = HeaderRange.Text;
                        if (HeaderText.Contains(BeforeName))
                        {
                            Console.WriteLine(HeaderText);                            
                            String AfterText = HeaderText.Replace(BeforeName, AfterName);   // 置換した文字列を生成

                            // ヘッダーに挿入
                            HeaderRange.Text = AfterText.Trim();    //改行文字や空白文字を除去
                            streamWriter.Write("ヘッダー部" + ",");
                            streamWriter.Write(HeaderText + ",");
                            streamWriter.WriteLine(AfterText);
                            Console.WriteLine(AfterText);
                            Console.WriteLine("ヘッダー部" + ConstantClass.SUCCESSMESSAGE);
                        }
                        else
                        {
                            Console.WriteLine(ConstantClass.ERRORMESSAGE);
                        }

                        // フッター
                        Range FooterRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        String FooterText = FooterRange.Text;
                        if (FooterText.Contains(BeforeName))
                        {
                            Console.WriteLine(FooterText);
                            String AfterText = FooterText.Replace(BeforeName, AfterName);   // 置換した文字列を生成

                            // フッターに挿入
                            FooterRange.Text = AfterText.Trim();    //改行文字や空白文字を除去
                            streamWriter.Write(FooterText + ",");
                            streamWriter.WriteLine(AfterText);
                            Console.WriteLine(AfterText);
                            Console.WriteLine("フッター部" + ConstantClass.SUCCESSMESSAGE);
                        }
                        else
                        {
                            Console.WriteLine(ConstantClass.ERRORMESSAGE);
                        }

                        // 保存
                        document.Save();
                        document.Close();
                        document = null;
                        application.Quit();
                        application = null;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                document.Close(WdSaveOptions.wdDoNotSaveChanges);   // 保存せず閉じる
                document = null;
                application.Quit();
                application = null;
            }
            
            // 操作を終了
            Console.WriteLine(ConstantClass.ENDMESSAGE);
            Console.ReadKey();
        }
    }
}
