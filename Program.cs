using System;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne();
            var personne2 = new Personne();

            personne1.Afficher("thomas", "Villier", 1990);
            personne2.Afficher("Nathalie", "Radhouane", 1997);


        }
    }
}
