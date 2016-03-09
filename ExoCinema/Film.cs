using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCinema
{
    class Film : Oeuvre
    {
        private string genre;
        private List<Acteur> acteurs;

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public List<Acteur> Acteurs
        {
            get
            {
                return acteurs;
            }

            set
            {
                acteurs = value;
            }
        }

        public override string afficherType()
        {
            return "Film";
        }

        public Film(string pGenre, string pTitre, string pAnneeSortie) :base(pTitre, pAnneeSortie)
        {
            this.Genre = pGenre;
            this.Acteurs = new List<Acteur>();
        }

    }
}
