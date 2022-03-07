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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
          

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            


        }
        private void Form4_Load(object sender, EventArgs e)
        {
            var q = from Player in Form1.Players
                    select Player;
            foreach (Player p in q)
            {
                comboBox1.SelectedText = p.Name;
                textBox1.Text = p.date;
                textBox2.Text = p.Duration.ToString();
                textBox3.Text = p.Score.ToString();
                textBox4.Text = p.Coins.ToString();
            }
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
            Form4 F4 = new Form4();
            F4.ShowDialog();
            this.Close();
        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F4 = new Form4();
            F4.ShowDialog();
            this.Close();
        }
    }
}
