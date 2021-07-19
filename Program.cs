using System;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne();
            var personne2 = new Personne();

            personne1.Afficher1("thomas", "Villier", 1990);
            personne2.Afficher1("Nathalie", "Radhouane", 1997);

            var animal1 = new Animal();
            var animal2 = new Animal();

            animal1.Afficher2("cat", "male", 21);
            animal2.Afficher2("horse", "female", 1);


        }
    }
}
