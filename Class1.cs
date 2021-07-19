using System;
using System.Collections.Generic;
using System.Text;

namespace Projet1
{
    class Personne
    {
        string p_name;
        string p_usname;
        int p_birtday;
        public void Afficher1 (string name, string usname, int birtday)
        {
            this.p_name = name;
            this.p_usname = usname;
            this.p_birtday = birtday;

            Console.WriteLine(name + usname + birtday);
        }
    }

    class Animal
    {
        string a_species;
        string a_gender;
        int a_age;

        public void Afficher2 (string species, string gender, int age)
        {
            this.a_species = species;
            this.a_gender = gender;
            this.a_age = age;

            Console.WriteLine(species + gender + age);
        }
    }
}
