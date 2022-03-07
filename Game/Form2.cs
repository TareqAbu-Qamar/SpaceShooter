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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, 
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10,
                    pictureBox1.Location.Y);

            if (e.KeyCode == Keys.Left)
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10,
                    pictureBox1.Location.Y);

            if (e.KeyCode == Keys.Up)
                pictureBox1.Location = new Point(pictureBox1.Location.X,
                    pictureBox1.Location.Y - 10);

            if (e.KeyCode == Keys.Down)
                pictureBox1.Location = new Point(pictureBox1.Location.X,
                    pictureBox1.Location.Y + 10);

        }
    }
}
