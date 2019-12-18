using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexagonal
{
    public partial class Hexagone : Form
    {
        public Hexagone()
        {
            InitializeComponent();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*
            var x0 = panel1.Width / 2;
            var y0 = panel1.Height / 2;
            var r = 70;
            var graphics = e.Graphics;
            var shape = new PointF[6];

            for (int i = 0; i < 6; i++)
            {

                shape[i] = new PointF(
                    x0 + r * (float)Math.Sin(i * 60 * Math.PI / 180F),
                    y0 + r * (float)Math.Cos(i * 60 * Math.PI / 180F)
                );
            }
           
            graphics.FillPolygon(Brushes.HotPink, shape);
            graphics.DrawPolygon(Pens.Black, shape);
            */

        }

        private void Hexagone_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Comes from" + Hexagon.HexagonNumber.ToString());

        }
    }
}
