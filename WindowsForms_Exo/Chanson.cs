using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Exo
{
    class Chanson
    {
        //#region Members
        String _nomArtiste;
        String _titreChanson;
        
        public Chanson(string nomArtiste, string titreChanson)
        {
            _nomArtiste = nomArtiste;
            _titreChanson = titreChanson;
        }
        
        //#endregion

        //#region Properties

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
        //#endregion

    }

  
    
}
