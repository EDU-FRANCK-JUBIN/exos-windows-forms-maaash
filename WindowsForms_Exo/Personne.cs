using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Exo
{
    internal class Personne
    {
        string nom;
        //string prenom;
        DateTime ddn;
        int age;

        public Personne(string nom)
        {
            this.nom = nom;
        }

        public Personne(string nom, DateTime ddn, int age)
        {
            this.nom = nom;
            //this.prenom = prenom;
            this.ddn = ddn;
            this.age = age;
        }

        public string Nom { get => nom; set => nom = value; }
        public DateTime Ddn { get => ddn; set => ddn = value; }
        public int Age { get => age; set => age = value; }
    }
}
