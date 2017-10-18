using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CAffichage
    {
        public void afficherClear(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }
        public void afficherSansClear(string message)
        {
            Console.WriteLine(message);
        }
    }
}