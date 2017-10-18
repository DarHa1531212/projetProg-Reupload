using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CFerraille
    {
        public CFerraille(int _QBlockMatierre)
        {
            QBlockMatierre = _QBlockMatierre;
        }
        CFerraille Suivant;
        int QBlockMatierre;
        public CFerraille _Suivant
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