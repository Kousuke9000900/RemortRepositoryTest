using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace じゃんけんテスト
{
    public partial class JyankenTest1 : Form
    {
        public JyankenTest1()
        {
            InitializeComponent();
        }

        // 使用変数
        int WinCount = 0;   // 勝利数
        int LoseCount = 0;  // 敗北数
        int Limit = 0;  // 制限時間        
        Boolean SubmitFlg = false;  // ボタンの種類判定に使用するフラグ
        Random random = new Random(); // ランダムクラスをインスタンス化
        List<String> Enemylist = new List<string>();  // 三択を格納するリスト

        // じゃんけんの選択肢格納コレクション
        Dictionary<String, int> MyChoise = new Dictionary<String, int>();       

        /// <summary>
        /// ロード時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JyankenTest1_Load(object sender, EventArgs e)
        {
            // コレクションに値代入
            MyChoise.Add("グー", 0);
            MyChoise.Add("チョキ", 1);
            MyChoise.Add("パー", 2);
            MyChoise.Add("グッチッパ", 10);

            // リストに三択を格納
            Enemylist.Add("グー");
            Enemylist.Add("チョキ");
            Enemylist.Add("パー");

            // メッセージ更新
            InfoMessage.Text = "開始ボタンを押すと開始されます";

            // ラジオボタンは押下不可
            MyRock.Enabled = false;
            MyScissors.Enabled = false;
            MyPapers.Enabled = false;
            Hidden.Enabled = false;
            Hidden.Visible = false;
            TimeInfo.Visible = false;
            CurrentTIme.Visible = false;

            // 勝敗数を初期化
            WinNumber.Text = WinCount.ToString();
            LoseNumber.Text = LoseCount.ToString();

            // 多機能ボタンの調整
            SomeButton.Text = "開始";

        }

        /// <summary>
        /// ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SomeButton_Click(object sender, EventArgs e)
        {
            // 決定ボタン以外
            if (SubmitFlg == false){
                Start();
            }

            // 決定ボタン
            else
            {
                Submit();
            }

        }

        /// <summary>
        /// 開始、もう一度ボタン押下時
        /// </summary>
        private void Start()
        {
            // 時間制限（10％の確率で5秒になる）
            if (random.Next(100) >= 90)
            {
                Limit = 5;
            }

            else
            {
                Limit = 15;
            }            

            // ラジオボタン活性
            MyRock.Enabled = true;
            MyScissors.Enabled = true;
            MyPapers.Enabled = true;
            if (LoseCount >= 20)
            {
                Hidden.Visible = true;
                Hidden.Enabled = true;
            }

            // 相手の選択肢活性
            EnemyRock.Visible = true;
            EnemyScissors.Visible = true;
            EnemyPapers.Visible = true;

            // メッセージ表示
            InfoMessage.Text = "グー・チョキ・パーのどれか選択してください";
            SomeButton.Text = "決定";

            // ラベル表示
            TimeInfo.Visible = true;
            CurrentTIme.Visible = true;
            CurrentTIme.Text = Limit.ToString();

            // 制限時間
            timer1.Enabled = true;
            timer1.Start();

            // フラグの切り替え
            SubmitFlg = true;
        }

        /// <summary>
        /// 決定ボタン押下時
        /// </summary>
        private void Submit()
        {
            // 結果に応じてメッセージを表示
            InfoMessage.Text = Judge();

            // タイマーを止める
            timer1.Stop();

            // フラグを戻し値を更新
            SubmitFlg = false;
            WinNumber.Text = WinCount.ToString();
            LoseNumber.Text = LoseCount.ToString();
            SomeButton.Text = "もう一回";
        }

        /// <summary>
        /// 開始時1秒毎の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 0秒になるまでカウントダウン
            if (Limit > 0)
            {
                Limit--;
                CurrentTIme.Text = Limit.ToString();
            }

            // 0秒でカウントを終了し、結果を表示
            if (Limit == 0)
            {
                InfoMessage.Text = "時間切れであなたの負けです";
                SomeButton.Text = "もう一回";
                LoseCount += 1;
                LoseNumber.Text = LoseCount.ToString();
                timer1.Stop();
                SubmitFlg = false;
            }
        }

        /// <summary>
        /// じゃんけんの勝敗判定
        /// </summary>
        /// <returns></returns>
        private String Judge()
        {
            // 勝敗に対応したメッセージを格納
            String JudgeMessage;

            // 計算用の値を取得
            int MyCalcNum;
            int EnemyCalcNum;

            // ラジオボタンの活性を調べ値を取得（グー）
            if (MyRock.Checked == true)
            {
                MyCalcNum = MyChoise[MyRock.Text];
            }

            // チョキ
            else if (MyScissors.Checked == true)
            {
                MyCalcNum = MyChoise[MyScissors.Text];
            }

            // パー
            else if(MyPapers.Checked == true)
            {
                MyCalcNum = MyChoise[MyPapers.Text];
            }

            // グッチッパ
            else
            {
                MyCalcNum = MyChoise[Hidden.Text];
            }

            // 相手の三択を格納
            List<String> RandomEnemylist = Enemylist.OrderBy(i => Guid.NewGuid()).ToList();
            EnemyCalcNum = MyChoise[RandomEnemylist[0]];

            // 相手の無作為に抽出された選択肢を画面に反映
            if (RandomEnemylist[0] == "グー")
            {
                EnemyRock.Visible = true;
                EnemyScissors.Visible = false;
                EnemyPapers.Visible = false;
            }

            else if(RandomEnemylist[0] == "チョキ")
            {
                EnemyRock.Visible = false;
                EnemyScissors.Visible = true;
                EnemyPapers.Visible = false;
            }

            else
            {
                EnemyRock.Visible = false;
                EnemyScissors.Visible = false;
                EnemyPapers.Visible = true;
            }

            // 勝敗の判定計算
            int JudgeNumber = ((MyCalcNum - EnemyCalcNum) + 3) % 3;
            
            // 計算結果により分岐
            if (JudgeNumber == 2 || MyCalcNum == 10)
            {
                JudgeMessage = "あなたの勝ちです";
                WinCount += 1;
            }

            else if (JudgeNumber == 1)
            {
                JudgeMessage = "あなたの負けです";
                LoseCount += 1;
            }

            else
            {
                JudgeMessage = "あいこです";
            }

            return JudgeMessage;
        }
    }
}
