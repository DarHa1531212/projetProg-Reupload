using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CVerre
    {
        int QBlockMatierre;
        CVerre Suivant;
        public CVerre(int _QBlockMatierre)
        {
            QBlockMatierre = _QBlockMatierre;
        }
        public CVerre _Suivant
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