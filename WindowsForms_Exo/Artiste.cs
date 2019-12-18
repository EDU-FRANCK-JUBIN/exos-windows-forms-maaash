using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Exo
{
    class Artiste
    {
        String _nomArtiste;
        Chanson[] chansons;

        public Artiste(string nomArtiste, Chanson[] chansons)
        {
            _nomArtiste = nomArtiste;
            this.chansons = chansons;
        }

        public string NomArtiste
        {
            get { return _nomArtiste; }
            set { _nomArtiste = value; }

        }

        

    }
}
