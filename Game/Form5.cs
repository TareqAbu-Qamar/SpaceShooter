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
    public partial class Form5 : Form
    {
        private static int Level = 1;
        private Player CurrentPlayer;
        static int[] Arr = { 0, 0, 0, 0, 0 };
        public Form5()
        {
            this.CurrentPlayer = new Player();
            InitializeComponent();
        }
        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            Point PBullet = new Point(Bullet.Location.X, Bullet.Location.Y);
            bool attempt = true;
            if (e.KeyData == Keys.Space)
            {
                
                while (attempt)
                {
                    /*while (Enemy5.Visible == true)
                    {
                        Enemy1.Location = new Point(Enemy3.Location.X - 10, Enemy3.Location.Y);
                        Enemy1.Location = new Point(Enemy3.Location.X + 10, Enemy3.Location.Y);
                    */
                        while (Bullet.Location.Y >= Enemy1.Location.Y)
                        {


                            Bullet.Location = new Point(Bullet.Location.X, Bullet.Location.Y - 5);

         
                        }
                        if (Bullet.Location.X == Enemy3.Location.X)
                        {

                            Enemy3.Visible = false;
                            Bullet.Location = PBullet;
                            if (Arr[0] == 0)
                            {
                                CurrentPlayer.Coins += 100;
                                coinL.Text = CurrentPlayer.Coins.ToString();
                                Arr[0] = 100;
                            }
                        }
                    
                    //---------------------- Enemy 1 -----------
                    
                 /*   if (Bullet.Location.X == Enemy3.Location.X)
                    {

                        Enemy3.Visible = false;
                        Bullet.Location = PBullet;
                        if (Arr[2] == 0)
                        {
                            CurrentPlayer.Coins += 100;
                            coinL.Text = CurrentPlayer.Coins.ToString();
                            Arr[4] = 100;
                        }
                    }
                    if (Bullet.Location.X == Enemy5.Location.X)
                    {

                        Enemy5.Visible = false;
                        Bullet.Location = PBullet;
                        if (Arr[0] == 0)
                        {
                            CurrentPlayer.Coins += 100;
                            coinL.Text = CurrentPlayer.Coins.ToString();
                            Arr[0] = 100;
                        }
                    }*/
                    Bullet.Location = PBullet;
                   
                    attempt = false; 
                }
                 //Form5 F5 = new Form5();
                 //F5.ShowDialog();
                 //this.Close();
            }
            if (e.KeyData == Keys.Right)
            {
                if (SpaceShooter.Location.X <= 440)
                {
                    SpaceShooter.Location = new Point(SpaceShooter.Location.X + 50, SpaceShooter.Location.Y);
                    Bullet.Location = new Point(Bullet.Location.X + 50, Bullet.Location.Y);
                }
            }
            if (e.KeyData == Keys.Left)
            {
                if (SpaceShooter.Location.X >= 40)
                {
                    SpaceShooter.Location = new Point(SpaceShooter.Location.X - 50, SpaceShooter.Location.Y);
                    Bullet.Location = new Point(Bullet.Location.X - 50, Bullet.Location.Y);
                }    
            }
            if (e.KeyData == Keys.A)
            {
                if (CurrentPlayer.Coins >= 10)
                {
                    Bullet.Image = game.Properties.Resources.icons8_ammo_30;
                    CurrentPlayer.Coins -= 10;
                    coinL.Text = CurrentPlayer.Coins.ToString();
                }
            }
            if (e.KeyData == Keys.S)
            {
                if (CurrentPlayer.Coins >= 50)
                {
                    Bullet.Image = game.Properties.Resources.icons8_missile_30;
                    CurrentPlayer.Coins -= 50;
                    coinL.Text = CurrentPlayer.Coins.ToString();
                }
            }
            if(e.KeyData == Keys.D)
            {
                if (CurrentPlayer.Coins >= 100)
                {
                    Bullet.Image = game.Properties.Resources.icons8_bomb_emoji_48;
                    CurrentPlayer.Coins -= 100;
                    coinL.Text = CurrentPlayer.Coins.ToString();
                }

            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
        }
        private void Left_Click(object sender, EventArgs e)
        {
        }
        private void Right_Click(object sender, EventArgs e)
        {
        }
        private void Shoot_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void BulletTimer_Tick(object sender, EventArgs e)
        {
        }
        private void Ecoin1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void currentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //=this.Close();

            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void Enemy2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateL_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

