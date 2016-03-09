using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCinema
{
    class Animation : Oeuvre
    {
        private string nomStudio;

        public override string afficherType()
        {
            return "Animation";
        }

        public Animation(string pNomStudio, string pTitre, string pAnneeSortie) : base(pTitre, pAnneeSortie)
        {
            this.nomStudio = pNomStudio;
        }


    }
}
