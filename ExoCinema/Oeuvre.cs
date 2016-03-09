using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCinema
{
    public class Oeuvre
    {
        protected string titre;
        protected string anneeSortie;
        public string AnneeSortie
        {
            get
            {
                return anneeSortie;
            }

            set
            {
                anneeSortie = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }


        public virtual string afficherType()
        {
            return "Oeuvre";
        }

        public Oeuvre(string pTitre, string pAnneeSortie)
        {
            this.Titre = pTitre;
            this.AnneeSortie = pAnneeSortie;
        }
        
    }
}
