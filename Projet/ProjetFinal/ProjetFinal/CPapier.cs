using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CPapier
    {
        CPapier Suivant;
        int QBlockMatierre;
        public CPapier(int _QBlockMatierre)
        {
            QBlockMatierre = _QBlockMatierre;
        }
        public CPapier _Suivant
        {
            set { Suivant = value; }
            get { return Suivant; }
        }
        public int _QBlockMatierre
        {
            get { return QBlockMatierre; }
        }
    }
}