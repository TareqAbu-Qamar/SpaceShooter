using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class CreateProfile : Form
    {
        Player player;
        private static List<Player> list = new List<Player>();
        private static Form1 f = new Form1();

        internal static List<Player> List { get => list; set => list = value; }
        public static Form1 F { get => f; set => f = value; }

        /*        void sendProfileList(List<Player> list)
                {
                    this.list = list;
                }*/

        public CreateProfile()
        {
            InitializeComponent();
        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player = new Player();
            player.name = textBox1.Text;
            if (radioButton1.Checked)
                player.gender = "Male";
            else
                player.gender = "Female";
            int a;
            //a= Convert.ToInt32()
            int.TryParse(comboBox1.SelectedText, out a);
            player.age = a;

            if (radioButton3.Checked)
            {
                //pictureBox1.Image = Properties.Resources._004_toy_story_cowboy_woody_png_clipart;
                //pictureBox1.Image = pictureBox2.Image;
                pictureBox1.Image = pictureBox2.Image;
                //player.toy = Properties.Resources._004_toy_story_cowboy_woody_png_clipart.ToString();
                player.toy = "C:\\Users\\Burhan\\Documents\\Visual Studio 2015\\Projects\\Game\\Game\\Game\\Resources\\a.jpg";
                //player.toy = "\\Resources\\a.jpg";
            }
            else if (radioButton4.Checked)
            {
                pictureBox1.Image = pictureBox3.Image;
                player.toy = "C:\\Users\\Burhan\\Documents\\Visual Studio 2015\\Projects\\Game\\Game\\Game\\Resources\\b.jpg";
                //player.toy = "\\Resources\\b.jpg";
            }

            else if (radioButton5.Checked)
            {
                pictureBox1.Image = pictureBox4.Image;
                player.toy = "C:\\Users\\Burhan\\Documents\\Visual Studio 2015\\Projects\\Game\\Game\\Game\\Resources\\c.jpg";
            }
            else
            {
                pictureBox1.Image = pictureBox5.Image;
                player.toy = "C:\\Users\\Burhan\\Documents\\Visual Studio 2015\\Projects\\Game\\Game\\Game\\Resources\\d.jpg";
                //player.toy = "\\Resources\\d.jpg";
            }

            List.Add(player);

            MessageBox.Show("Added new player: " + player.name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
