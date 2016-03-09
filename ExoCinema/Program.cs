using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCinema
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Oeuvre> Oeuvres = new List<Oeuvre>();
            Oeuvres.Add(new Oeuvre("MehTitre", "1992"));
            Oeuvres.Add(new Film("Science Fiction", "MehTitreScienceF", "1987"));
            Oeuvres.Add(new Animation("NomStutioMeh", "TitreStudioMeh", "1956"));
            Oeuvres.Add(new Oeuvre("MehQuatre", "1995"));
            Oeuvres.Add(new Oeuvre("MehCinq", "1996"));
            Oeuvres.Add(new Film("Science Fiction", "MehTitreScienceF", "1987"));
            Oeuvres.Add(new Animation("DeuxiemeStudioAnim", "TitreStudioMeh", "1956"));


            foreach (var meh in Oeuvres)
            {
                
                Console.Write(meh.afficherType() + "        " );
                Console.Write(Convert.ToString(meh) + "         ");
                Console.WriteLine(meh.Titre);
            }

            Console.Read();

        }
    }
    
}
