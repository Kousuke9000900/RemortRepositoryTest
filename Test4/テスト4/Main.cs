using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace テスト4
{
    public partial class Main : Form
    {
        Point point;    // ポイント構造体宣言
        Boolean myShootFlg = false;  // true:装填待ち
        Boolean enemyShootFlg = false;  // true:装填待ち
        Random random = new Random();   // 乱数

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロード時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            initGame();
        }

        /// <summary>
        /// 時間毎の処理(myTimer)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayerMove();   // 自機動作
            EnemyMove();    // 敵機動作   
            hitJudge();     // 当たり判定

            // 自機弾発射
            if (myShootFlg)
            {
                MyBulletMove();
            }

            // 敵機弾発射
            if (enemyShootFlg)
            {
                EnemyBulletMove();
                return;
            }
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private void initGame()
        {
            // 各種初期化
            initPlayer();
            initEnemy();
            initBullet();
            initEnemyBullet();
            Bullet.Hide();
            EnemyBullet.Hide();
            retryButton.Hide();
        }

        /// <summary>
        /// 自機処理
        /// </summary>
        private void PlayerMove()
        {
            // マウスの動きに合わせて自機が動く設定（自機は中央の座標とマウスポインタが連動して動く）
            point = PointToClient(Cursor.Position);     // マウスポインタの座標計算
            Player.Top = point.Y - (Player.Height / 2); // 自機の座標をマウスポインタの座標に設定

            // 弾の動作
            initBullet();
            
            // 自機が画面外に出ない調整（上部）
            if (Player.Top < 0)
            {
                Player.Top = 0; // 自機の上底がY座標0より上に行った場合、上底の座標を0に固定する
            }

            // 下部（計算にはクライアント座標を算出）
            if (Player.Bottom > ClientRectangle.Height)
            {
                Player.Top = ClientRectangle.Height - Player.Height;   // 自機の下底がフォームのY座標の一番下に行った場合、下底の座標をフォームの一番下に固定
            }

        }

        /// <summary>
        /// 敵機処理
        /// </summary>
        private void EnemyMove()
        {
            // 左に移動
            Enemy.Left -= 1;

            // 弾を追随して動かす
            initEnemyBullet();

            // 1％の確率で弾を発射する
            if (random.Next(100) >= 99)
            {
                enemyShootFlg = true;
            }

            // x座標が限界に達した時、位置を戻す
            if (Enemy.Left + Enemy.Width == ClientRectangle.Left)
            {
                initEnemy();
            }
        }

        /// <summary>
        /// 自機初期化処理
        /// </summary>
        private void initPlayer()
        {
            Player.Show();
        }

        /// <summary>
        /// 敵機初期化処理
        /// </summary>
        private void initEnemy()
        {
            // 初期位置
            Enemy.Location = new Point(800,random.Next(400));
            Enemy.Show();
        }

        /// <summary>
        /// 自機弾初期化処理
        /// </summary>
        private void initBullet()
        {
            // 自機に追随して弾が動く
            if (myShootFlg == false)
            {
                Bullet.Left = Player.Left + Player.Height;
                Bullet.Top = point.Y - (Player.Height / 2);
            }
        }

        /// <summary>
        /// 敵機弾初期化処理
        /// </summary>
        private void initEnemyBullet()
        {
            // 敵機に追随して動く
            if (enemyShootFlg == false)
            {
                EnemyBullet.Left = Enemy.Left - EnemyBullet.Width;
                EnemyBullet.Top = Enemy.Top;
            }
        }

        /// <summary>
        /// 自機弾処理
        /// </summary>
        private void MyBulletMove()
        {
            // 右に移動
            Bullet.Left += 5;    

            // 座標が限界に達した時初期化
            if (Bullet.Left >= ClientRectangle.Right)
            {
                initBullet();
                myShootFlg = false;
                Bullet.Hide();
            }
        }

        /// <summary>
        /// 敵機弾処理
        /// </summary>
        private void EnemyBulletMove()
        {
            // 左に移動
            EnemyBullet.Show();
            EnemyBullet.Left -= 3;

            // 座標が限界に達した時初期化
            if ((EnemyBullet.Left + EnemyBullet.Width) <= ClientRectangle.Left)
            {
                initEnemyBullet();
                enemyShootFlg = false;
                EnemyBullet.Hide();
            }
        }

        /// <summary>
        /// マウスクリック時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            // 弾を表示
            Bullet.Show();
            myShootFlg = true;

        }

        /// <summary>
        /// 当たり判定
        /// </summary>
        private void hitJudge()
        {
            // 自機弾→敵機
            if (Bullet.Left < Enemy.Right && Bullet.Top < Enemy.Bottom && Bullet.Right > Enemy.Left && Bullet.Bottom >= Enemy.Top)
            {
                // 敵機消滅
                Enemy.Image = null;
                Enemy.Hide();           

                initEnemy();            // 敵機初期化
                Bullet.Hide();          // 弾非表示            
                initBullet();           // 自機弾初期化
                myShootFlg = false;     // 発射フラグを戻す

            }

            // 敵機弾→自機
            if (Player.Left < EnemyBullet.Right && Player.Top < EnemyBullet.Bottom && Player.Right > EnemyBullet.Left && Player.Bottom > EnemyBullet.Top)
            {
                // タイマー停止
                myTimer.Stop();
                retryButton.Show();

                // 自機消滅
                Player.Image = null;
                Player.Hide();
                EnemyBullet.Hide();
            }
        }

        /// <summary>
        /// リトライ押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 初期化
            initGame();
            myTimer.Start();
        }
    }
}
