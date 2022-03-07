using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Level2 : Form
    {
        private static int Level = 1;
        private Player CurrentPlayer;
        static int[] Arr = { 0, 0, 0, 0, 0 };
        public Level2()
        {
            InitializeComponent();
            MessageBox.Show("Upgrade to level 2");

        }
        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            Point PBullet = new Point(Bullet.Location.X, Bullet.Location.Y);
            bool EnemiesMove = true;
            while (EnemiesMove)
            {
                while (Enemy1.Location.X <= Enemy2.Location.X && Enemy3.Location.X <= Enemy4.Location.X
                        && Enemy5.Location.X <= Enemy5.Location.X + 50)
                {
                    Enemy1.Location = new Point(Enemy1.Location.X + 1, Enemy1.Location.Y);
                    Enemy3.Location = new Point(Enemy3.Location.X + 1, Enemy3.Location.Y);
                    Enemy5.Location = new Point(Enemy5.Location.X + 1, Enemy5.Location.Y);
                    if (Bullet.Location.X == Enemy1.Location.X)
                    {
                        while (Bullet.Location.Y >= Enemy1.Location.Y)
                        {
                            Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                        }
                        Enemy1.Visible = false;
                        Bullet.Location = PBullet;
                        if (Arr[0] == 0)
                        {
                            CurrentPlayer.Coins += 100;
                            coinL.Text = CurrentPlayer.Coins.ToString();
                            Arr[0] = 100;
                        }
                    }
                    //90,57
                    if (Bullet.Location.X == ((Enemy1.Location.X + Enemy2.Location.X) / 2))
                    {
                        while (Bullet.Location.Y >= Enemy1.Location.Y)
                        {
                            Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                        }
                        Bullet.Location = PBullet;
                    }
                    //-----
                    if (Bullet.Location.X == Enemy3.Location.X)
                    {
                        while (Bullet.Location.Y >= Enemy3.Location.Y)
                        {
                            Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                        }

                        Enemy3.Visible = false;
                        Bullet.Location = PBullet;
                        if (Arr[2] == 0)
                        {
                            CurrentPlayer.Coins += 100;
                            coinL.Text = CurrentPlayer.Coins.ToString();
                            Arr[2] = 100;
                        }
                    }
                    //290,57
                    if (Bullet.Location.X == ((Enemy3.Location.X + Enemy4.Location.X) / 2))
                    {
                        while (Bullet.Location.Y >= 57)
                        {
                            Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                        }
                        Bullet.Location = PBullet;
                    }
                    //---------------------- Enemy 5 -----------
                    if (Bullet.Location.X == Enemy5.Location.X)
                    {
                        while (Bullet.Location.Y >= Enemy5.Location.Y)
                        {
                            Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                        }
                        Enemy5.Visible = false;
                        Bullet.Location = PBullet;
                        if (Arr[4] == 0)
                        {
                            CurrentPlayer.Coins += 100;
                            coinL.Text = CurrentPlayer.Coins.ToString();
                            Arr[4] = 100;
                        }
                    }
                    //490,57
                    if (Bullet.Location.X == (Enemy5.Location.X + 50))
                    {
                        while (Bullet.Location.Y >= Enemy5.Location.Y)
                        {
                            Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                        }
                        Bullet.Location = PBullet;
                    }

                }

            }
            // move left 
            while (Enemy1.Location.X >= Enemy1.Location.X - 50 && Enemy3.Location.X >= Enemy3.Location.X - 50
                       && Enemy5.Location.X >= Enemy5.Location.X - 50)
            {
                Enemy1.Location = new Point(Enemy1.Location.X - 2, Enemy1.Location.Y);
                Enemy3.Location = new Point(Enemy3.Location.X - 2, Enemy3.Location.Y);
                Enemy5.Location = new Point(Enemy5.Location.X - 2, Enemy5.Location.Y);

                if (Bullet.Location.X == Enemy1.Location.X)
                {
                    while (Bullet.Location.Y >= Enemy1.Location.Y)
                    {
                        Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                    }
                    Enemy1.Visible = false;
                    Bullet.Location = PBullet;
                    if (Arr[0] == 0)
                    {
                        CurrentPlayer.Coins += 100;
                        coinL.Text = CurrentPlayer.Coins.ToString();
                        Arr[0] = 100;
                    }
                }
                //90,57
                if (Bullet.Location.X == ((Enemy1.Location.X + Enemy2.Location.X) / 2))
                {
                    while (Bullet.Location.Y >= Enemy1.Location.Y)
                    {
                        Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);
                    }
                    Bullet.Location = PBullet;
                }

            }

            if (e.KeyData == Keys.Right)
            {
                if (SpaceShooter.Location.X <= 440)
                {
                    SpaceShooter.Location = new Point(SpaceShooter.Location.X + 1, SpaceShooter.Location.Y);
                    Bullet.Location = new Point(Bullet.Location.X + 1, Bullet.Location.Y);
                }
            }
            if (e.KeyData == Keys.Left)
            {
                if (SpaceShooter.Location.X >= 40)
                {
                    SpaceShooter.Location = new Point(SpaceShooter.Location.X - 2, SpaceShooter.Location.Y);
                    Bullet.Location = new Point(Bullet.Location.X - 2, Bullet.Location.Y);
                }
            }


        }

        private void Level2_Load(object sender, EventArgs e)
        {

        }
    }
}
