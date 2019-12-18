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
    public partial class Exo_dbind : Form
    {
        public Exo_dbind()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       public void load_chanson()
        {
            
            Chanson c0 = new Chanson("Highlight Tribe", "Free Tibet");
            Chanson c1 = new Chanson("Pendulum", "Blood Sugar");
            Chanson c2 = new Chanson("Powerwolf", "Deus Vult");
            Chanson c3 = new Chanson("Highlight Tribe", "Esperanza");
            Chanson c4 = new Chanson("Archenemy", "War Eternal");
            Chanson c5 = new Chanson("PrototypeRaptor", "Last Sprite Standing");

            

            String[] artistes = { "Highlight Tribe", "Pendulum", "Powerwolf", "Archenemy", "PrototypeRaptor" };
            String[] titres = new String[10];

            for (int i = 0; i<10; i++)
            {

            }

        }

    }
}
