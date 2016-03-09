using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCinema
{
    class Acteur
    {
        private string nom;
        private string prenom;

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }


        public Acteur(string pNom, string pPrenom)
        {
            this.Nom = pNom;
            this.Prenom = pPrenom;
        }
    }

}
