using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
      class CPlastique
      {
        int QBlockMatierre;
        CPlastique Suivant;
        public CPlastique(int _QBlockMatierre)
        {
            QBlockMatierre = _QBlockMatierre;
        }
      public CPlastique _Suivant
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