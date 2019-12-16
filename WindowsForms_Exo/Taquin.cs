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
    public partial class Taquin : Form
    {
        public Taquin()
        {
            InitializeComponent();
        }
  

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

            List<Bitmap> listPictures = new List<Bitmap>();
            Random random = new Random();
            List<int> possible = Enumerable.Range(0, 9).ToList();
            List<int> numList = new List<int>();

            //adding pictures to list
            listPictures.Add(Properties.Resources._1);
            listPictures.Add(Properties.Resources._2);
            listPictures.Add(Properties.Resources._3);
            listPictures.Add(Properties.Resources._4);
            listPictures.Add(Properties.Resources._5);
            listPictures.Add(Properties.Resources._6);
            listPictures.Add(Properties.Resources._7);
            listPictures.Add(Properties.Resources._8);
            listPictures.Add(Properties.Resources._9);

            listPictures.Add(Properties.Resources._null);



            for (int i = 0; i < 9; i++)
            {
                int index = random.Next(0, possible.Count);
                numList.Add(possible[index]);
                possible.RemoveAt(index);
                
            }
            for (int i = 0; i < 9; i++)
            {
                ((PictureBox)puzzleBox.Controls[i]).Image = listPictures[numList[i]];
                ((PictureBox)puzzleBox.Controls[i]).Image.Tag = i;

            }

            int j = random.Next(0, 9);
            ((PictureBox)puzzleBox.Controls[j]).Image = listPictures[9];




        }
        Bitmap image_null = Properties.Resources._null;
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox1.Image;
            if (pictureBox2.Image == (Image)Properties.Resources._null.Ta)
            {
                MessageBox.Show("Hello");
                pictureBox1.Image = Properties.Resources._null;
                pictureBox2.Image = temp;
            }

            if (pictureBox4.Image == (Image)Properties.Resources._null)
            {
                pictureBox1.Image = (Image)Properties.Resources._null;
                pictureBox4.Image = temp;
            }
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox2.Image;
            if (pictureBox1.Image == Properties.Resources._null)
            {
                pictureBox2.Image = Properties.Resources._null;
                pictureBox1.Image = temp;
            }

            if (pictureBox3.Image == Properties.Resources._null)
            {
                pictureBox2.Image = Properties.Resources._null;
                pictureBox3.Image = temp;
            }

            if (pictureBox5.Image == Properties.Resources._null)
            {
                pictureBox2.Image = Properties.Resources._null;
                pictureBox5.Image = temp;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox3.Image;
            if (pictureBox2.Image == Properties.Resources._null)
            {
                pictureBox3.Image = Properties.Resources._null;
                pictureBox2.Image = temp;
            }

            if (pictureBox5.Image == Properties.Resources._null)
            {
                pictureBox3.Image = Properties.Resources._null;
                pictureBox5.Image = temp;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox4.Image;
            if (pictureBox1.Image == Properties.Resources._null)
            {
                pictureBox4.Image = Properties.Resources._null;
                pictureBox1.Image = temp;
            }

            if (pictureBox5.Image == Properties.Resources._null)
            {
                pictureBox4.Image = Properties.Resources._null;
                pictureBox5.Image = temp;
            }

            if (pictureBox7.Image == Properties.Resources._null)
            {
                pictureBox4.Image = Properties.Resources._null;
                pictureBox7.Image = temp;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox5.Image;
            if (pictureBox2.Image == Properties.Resources._null)
            {
                pictureBox5.Image = Properties.Resources._null;
                pictureBox2.Image = temp;
            }

            if (pictureBox4.Image == Properties.Resources._null)
            {
                pictureBox5.Image = Properties.Resources._null;
                pictureBox4.Image = temp;
            }

            if (pictureBox6.Image == Properties.Resources._null)
            {
                pictureBox5.Image = Properties.Resources._null;
                pictureBox6.Image = temp;
            }
            
            if (pictureBox8.Image == Properties.Resources._null)
            {
                pictureBox5.Image = Properties.Resources._null;
                pictureBox8.Image = temp;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox6.Image;
            if (pictureBox3.Image == Properties.Resources._null)
            {
                pictureBox6.Image = Properties.Resources._null;
                pictureBox3.Image = temp;
            }

            if (pictureBox5.Image == Properties.Resources._null)
            {
                pictureBox6.Image = Properties.Resources._null;
                pictureBox5.Image = temp;
            }

            if (pictureBox9.Image == Properties.Resources._null)
            {
                pictureBox6.Image = Properties.Resources._null;
                pictureBox9.Image = temp;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox7.Image;
            if (pictureBox4.Image == Properties.Resources._null)
            {
                pictureBox7.Image = Properties.Resources._null;
                pictureBox4.Image = temp;
            }

            if (pictureBox8.Image == Properties.Resources._null)
            {
                pictureBox7.Image = Properties.Resources._null;
                pictureBox8.Image = temp;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox8.Image;
            if (pictureBox5.Image == Properties.Resources._null)
            {
                pictureBox8.Image = Properties.Resources._null;
                pictureBox5.Image = temp;
            }

            if (pictureBox7.Image == Properties.Resources._null)
            {
                pictureBox8.Image = Properties.Resources._null;
                pictureBox7.Image = temp;
            }

            if (pictureBox9.Image == Properties.Resources._null)
            {
                pictureBox8.Image = Properties.Resources._null;
                pictureBox9.Image = temp;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Drawing.Image temp = pictureBox9.Image;
            if (pictureBox8.Image == Properties.Resources._null)
            {
                pictureBox9.Image = Properties.Resources._null;
                pictureBox8.Image = temp;
            }

            if (pictureBox6.Image == Properties.Resources._null)
            {
                pictureBox9.Image = Properties.Resources._null;
                pictureBox6.Image = temp;
            }
        }
    }
}
