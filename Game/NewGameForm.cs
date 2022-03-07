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
    public partial class NewGameForm : Form
    {
        internal List<Player> players = new List<Player>();

        List<Player> list = new List<Player>();
        //NewGameForm newF = new NewGameForm();
        //Form1 f = new Form1();
        public NewGameForm()
        {
            InitializeComponent();
        }

        void getProfileList(List<Player> list)
        {
            this.list = list;
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            this.getProfileList(CreateProfile.List);

            foreach (Player p in list)
            {
                comboBox1.Items.Add(p.name);
                comboBox2.Items.Add(p.name);

                players.Add(p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateProfile.F.getPlayersList(players);
            CreateProfile.F.Show();
        }
    }
}
