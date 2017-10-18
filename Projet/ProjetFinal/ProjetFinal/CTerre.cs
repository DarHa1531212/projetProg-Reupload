using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CTerre
    {
        int QBlockMatierre;
        CTerre Suivant;
        public CTerre(int _QBlockMatierre)
        {
            QBlockMatierre = _QBlockMatierre;
        }
        public CTerre _Suivant
        {
            get { return Suivant; }
            set { Suivant = value; }
        }
        public int _QBlockMatierre
        {
            get { return QBlockMatierre; }
        }
    }
}