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
    public partial class Form3 : Form
    {
        Form1 F1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            int MD = 0, mD = 0, Sum = 0;
            var query = from Player in Form1.Players
                        select Player;

            foreach (Player p in query)
            {
                y = p.Score;
                mD = p.Duration;
                if (p.Score > x) { x = p.Score; }
                if (p.Score < y) { y = p.Score; }
                if (p.Duration > MD) { MD = p.Duration; }
                if (p.Duration < mD) { mD = p.Duration; }
                Sum += p.Duration;
                label8.Text = p.NumberOfGame.ToString();
                label9.Text = p.NumberOfProfiles.ToString();
            }
            
            label10.Text = x.ToString();
            label11.Text = y.ToString();
            label12.Text = MD.ToString();
            label13.Text = mD.ToString();
            label14.Text = Sum.ToString(); 
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void currentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.ShowDialog();
            this.Close();
        }
        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.ShowDialog();
            this.Close();
        }
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F3 = new Form3();
            F3.ShowDialog();
            this.Close();
        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F4 = new Form4();
            F4.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void numofgame_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Item_Click(object sender, EventArgs e)
        {

        }

        private void value_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
