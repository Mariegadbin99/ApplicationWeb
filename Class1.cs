using System;
using System.Collections.Generic;
using System.Text;

namespace Projet1
{
    class Personne
    {
        string m_name;
        string m_usname;
        int m_birtday;
        public void Afficher (string name, string usname, int birtday)
        {
            this.m_name = name;
            this.m_usname = usname;
            this.m_birtday = birtday;

            Console.WriteLine(name + usname + birtday);
        }
    }
}
