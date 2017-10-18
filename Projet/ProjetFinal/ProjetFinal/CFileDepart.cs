using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CFileDepart
    {  
        CVaisseaux DepartAncre;
        CVaisseaux DepartDernier;
        public CVaisseaux _Ancre
        {
            get { return DepartAncre; }
        }
        public CVaisseaux _Queue
        {
            get { return DepartDernier; }
        }
        public void AjouterChainonDepart(CVaisseaux Vaisseaux)
        {
            if (DepartAncre == null)
            {
                Vaisseaux._Suivant = null;  //insérer premier élement
                DepartAncre = Vaisseaux;
                DepartDernier = Vaisseaux;
            }
            else if (DepartAncre._Suivant == null)
            {
                DepartAncre._Suivant = Vaisseaux;
                DepartDernier = Vaisseaux;
            }
            else
            {
                Vaisseaux._Suivant = DepartDernier;  //insérer élement
                DepartDernier = Vaisseaux;
            }
        }
        public void EnleverChainonDepart(CVaisseaux Vaisseaux)
        {
            DepartAncre = Vaisseaux._Suivant;  //enlever un élement
            Vaisseaux._Suivant = null;
        }
    }
}