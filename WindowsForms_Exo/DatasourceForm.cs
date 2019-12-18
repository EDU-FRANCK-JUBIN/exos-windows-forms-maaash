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
    public partial class DatasourceForm : Form
    {
        public DatasourceForm()
        {
            InitializeComponent();
        }

        private void DatasourceForm_Load(object sender, EventArgs e)
        {
            List<Personne> pliste = new List<Personne>();
            pliste.Add(new Personne("Chasse", DateTime.Parse("14/02/1998"), 21));
            pliste.Add(new Personne("Mugi", DateTime.Parse("14/02/1988"), 31));
            pliste.Add(new Personne("Argo", DateTime.Parse("14/02/1998"), 21));

            personneBindingSource.DataSource = pliste;
        }

   

        
    }
}
