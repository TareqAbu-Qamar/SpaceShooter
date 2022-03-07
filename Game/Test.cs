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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.GetItemText(comboBox1.SelectedIndex);
            //comboBox1.SelectedItem.ToString();
            float n;
            float.TryParse(comboBox1.Text, out n);
            textBox1.Font = new Font(Font.FontFamily,
                n/*, Font.Style ^ FontStyle.Bold*/);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float n;
            float.TryParse(comboBox1.Text, out n);
            textBox1.Font = new Font(Font.FontFamily,
                n/*, Font.Style ^ FontStyle.Bold*/);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, this.Width+1);
            int y = rnd.Next(0, this.Height+1);
            //1940, 1100
            button4.Location = new Point(x, y);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void Test_MouseClick(object sender, MouseEventArgs e)
        {
            string s = "";

            s += "location: " + e.Location.ToString() + "\n" +
                "X-axis: " + e.X.ToString() + "\n" +
                "Y-axis: " + e.Y.ToString() + "\n" +
                "Number of Clicks" + e.Clicks + "\n" +
                "Button" + e.Button;

            MessageBox.Show(s);



        }
    }
}
