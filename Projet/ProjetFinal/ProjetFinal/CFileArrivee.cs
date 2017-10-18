using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CFileArrivee
    {
        CVaisseaux ArriveAncre;
        CVaisseaux ArriveDernier;

        public CVaisseaux _Ancre
        {
            get { return ArriveAncre; }
        }
        public CVaisseaux _Queue
        {
            get { return ArriveDernier; }
        }
        public void AjouterChainonArrive(CVaisseaux Vaisseaux)
        {
            if (ArriveAncre == null)
            {
                Vaisseaux._Suivant = null;  //insérer premier élement
                ArriveAncre = Vaisseaux;
                ArriveDernier = Vaisseaux;
            }
            else if (ArriveAncre._Suivant == null)
            {
                ArriveAncre._Suivant = Vaisseaux;  
                // insérer un deuxieme element
                ArriveDernier = Vaisseaux;
            }
            else
            {
                ArriveDernier._Suivant = Vaisseaux;
                ArriveDernier = Vaisseaux;//inserer les autres elements
            }
        }
        public void EnleverChainonArrive(CVaisseaux Vaisseaux)
        {
            if (Vaisseaux._Suivant == null)
                ArriveAncre = null;
            else
            {
                ArriveAncre = Vaisseaux._Suivant;  //enlever un élement
                Vaisseaux._Suivant = null;
            }
        }
    }
}