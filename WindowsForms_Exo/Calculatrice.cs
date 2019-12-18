using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {

            textBoxResult.Text = "";
            //textBoxResult.Text.Remove(0, textBoxResult.Text.Length);

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = "";
            //textBoxScreen.Text.Remove(0, textBoxScreen.Text.Length);
            textBoxResult.Text = "";
            //textBoxResult.Text.Remove(0, textBoxResult.Text.Length);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text.Substring(0, textBoxScreen.Text.Length - 1);
        }

        private void buttonSlash_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("3");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("0");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("*");
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText("+");
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxScreen.AppendText(".");
        }

        private void buttonPlusMoins_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Substring(0,1) == "-")
            {
                textBoxResult.Text = textBoxResult.Text.Substring(1, textBoxResult.Text.Length-1);
                //textBoxResult = textBoxResult.Text.Remove(0, 1);

            }else
            {
                textBoxResult.Text = "-" + textBoxResult.Text;
            }
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (textBoxScreen.Text.Contains("/0"))
            {
                MessageBox.Show("Erreur division par 0 !");
            } else {
                var temp = dt.Compute(textBoxScreen.Text, "");
                textBoxResult.Text = temp.ToString();
            }
        }
    }
}
