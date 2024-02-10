using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_da
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox1.Text = "Odabrali ste:\r\ndorucak\r\nveceru";
            }
            else
            {
                textBox1.Text = "nije točno odabrano";
            }
        }
    }
}
