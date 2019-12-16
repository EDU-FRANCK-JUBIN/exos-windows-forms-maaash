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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public class Chanson{
            #region Membres
            String _nomArtiste;
            String _titreChanson;

            public Chanson(string nomArtiste, string titreChanson)
            {
                _nomArtiste = nomArtiste;
                _titreChanson = titreChanson;
            }
            #endregion

            #region Propriété

            public string NomArtiste
            {
                get { return _nomArtiste; }
                set { _nomArtiste = value; }

            }

            public string TitreChanson
            {
                get { return _titreChanson; }
                set { _titreChanson = value; }

            }
            #endregion

        }

    }
}
