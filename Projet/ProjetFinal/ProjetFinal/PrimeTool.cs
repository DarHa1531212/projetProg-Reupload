using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class PrimeTool
    {
        public bool IsPrime(int Nombre)
        {
            if ((Nombre & 1) == 0)
            {
                if (Nombre == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= Nombre; i += 2)
            {
                if ((Nombre % i) == 0)
                {
                    return false;
                }
            }
            return Nombre != 1;
        }
    }
}
