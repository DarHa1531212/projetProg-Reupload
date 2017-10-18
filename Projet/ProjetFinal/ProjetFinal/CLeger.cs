using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CLeger : CVaisseaux
    {
        public CLeger(int _QtePapier, int _QteVerre, int _QtePlastique, int _QteFerraille, int _QteTerre, int _QteMax, CVaisseaux _Suivant) : base(_QtePapier, _QteVerre, _QtePlastique, _QteFerraille, _QteTerre, 108, _Suivant)
        {
        }
    }
}