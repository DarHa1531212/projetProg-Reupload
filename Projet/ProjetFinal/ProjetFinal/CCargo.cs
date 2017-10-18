using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CCargo: CVaisseaux
    {
		int QtePapier, QteVerre, QtePlastique, QteFerraille, QteTerre, QteMax;
		CVaisseaux Suivant;

        public CCargo(int _QtePapier, int _QteVerre, int _QtePlastique, int _QteFerraille, int _QteTerre, int _QteMax, CVaisseaux _Suivant) : base(_QtePapier, _QteVerre, _QtePlastique, _QteFerraille, _QteTerre, 367, _Suivant)
        {
		}
    }

}