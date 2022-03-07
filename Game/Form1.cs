using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {

        bool p1 = false;
        bool p2 = false;


        internal List<Player> list = new List<Player>();

        internal List<Player> players = new List<Player>();

        public static CreateProfile c = new CreateProfile();
        public static NewGameForm newForm = new NewGameForm();

        internal void getPlayersList(List<Player> players)
        {
            this.players = players;
        }

        void getProfileList(List<Player> list)
        {
            this.list = list;
        }
        public Form1()
        {
            InitializeComponent();
            p1 = true;
        }

        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.Show();
            this.getProfileList(CreateProfile.List);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(player2.BackColor.ToString());
/*            player2.BackColor = Color.Transparent;
            player2.Parent = player1;
            player2.Location = new Point(0, 0);*/

/*            TableLayoutPanelCellPosition cellPos = new TableLayoutPanelCellPosition(0, 0);
            this.tableLayoutPanel1.SetCellPosition(player1, cellPos);*/

            this.getProfileList(CreateProfile.List);

            if (list.Count < 2)
                newGameToolStripMenuItem.Enabled = false;
            else
                newGameToolStripMenuItem.Enabled = true;

            label1.Text = DateTime.Now.ToString();

            if (players.Count > 0)
            {
                Image pl1 = Image.FromFile(players[0].toy);
                Image pl2 = Image.FromFile(players[1].toy);

                player1.Image = pl1;

                player2.Image = pl2;

                pictureBox2.Image = Image.FromFile(players[0].toy);
                pictureBox3.Image = Image.FromFile(players[1].toy);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 7);
            MessageBox.Show(r.ToString());
            tableLayoutPanel3.Visible = false;
            
            

            if (p1 == true)
            {
                TableLayoutPanelCellPosition cellPos1 = new TableLayoutPanelCellPosition(0, 0);
                tableLayoutPanel1.SetCellPosition(player1, cellPos1);


            }

            else
            {

 
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void createProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.Show();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            newForm.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
   
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                player1.Location = new Point
                    (player1.Location.X, player1.Location.Y - 1);
            }

            if (e.KeyCode == Keys.D)
            {
                player1.Location = new Point
                    (player1.Location.X+1, player1.Location.Y);
            }
        }

        private void player1_Click(object sender, EventArgs e)
        {

        }
    }
}
