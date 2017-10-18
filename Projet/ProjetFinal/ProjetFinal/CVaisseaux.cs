using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{   
    class CVaisseaux
    {
        int QtePapier, QteVerre, QtePlastique, QteFerraille, QteTerre,QteMax;
        CVaisseaux Suivant;
        public CVaisseaux(int _QtePapier, int _QteVerre, int _QtePlastique, int _QteFerraille, int _QteTerre, int _QteMax, CVaisseaux _Suivant) 
        {
            QtePapier = _QtePapier;
            QteVerre = _QteVerre;
            QtePlastique = _QtePlastique;
            QteFerraille = _QteFerraille;
            QteTerre = _QteTerre;
            QteMax = _QteMax;
            Suivant = _Suivant;
        }
        public CVaisseaux _Suivant
        {
            get { return Suivant; }
            set { Suivant = value; }
        }
        public int _QteTerre
        {
            get { return QteTerre; }
            set { QteTerre = value; }
        }
        public int _QteVerre
        {
            get { return QteVerre; }
            set { QteVerre = value; }
        }
        public int _QteMax
        {
            get { return QteMax; }
        }
        public int _QtePapier
        {
            get { return QtePapier; }
            set { QtePapier = value; }
        }
        public int _QtePlastique
        {
            get { return QtePlastique; }
            set { QtePlastique = value; }
        }
        public int _QteFerraille
        {
            get { return QteFerraille; }
            set { QteFerraille = value; }
        }
    }
}