using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Exo
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = listBoxVilles.GetItemText(listBoxVilles.SelectedItem);
            MessageBox.Show(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = textBoxNom.Text;
            String adresse = textBoxAdresse.Text;
            MessageBox.Show(nom +" : " + adresse);
        }
    }
}
