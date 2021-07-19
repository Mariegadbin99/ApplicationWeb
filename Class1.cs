using System;
using System.Collections.Generic;
using System.Text;

namespace Projet1
{
    class Personne
    {
        string p_name;
        string p_usname;
        DateTime p_birtday;
        public void Afficher1 (string name, string usname, DateTime birtday)
        {
            this.p_name = name;
            this.p_usname = usname;
            this.p_birtday = birtday;

            Console.WriteLine(name + usname + birtday);
        }

        public bool IsYourBirthday()
        {

            if ((DateTime.Now.Day == p_birtday.Day) && (DateTime.Now.Month == p_birtday.Month))
            {
                return true;
            }
            else
            {
                return false;
            }
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
