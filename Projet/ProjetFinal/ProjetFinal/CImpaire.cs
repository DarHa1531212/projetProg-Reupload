using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CImpaire : CCentreTri
    {
        public CImpaire(int nombre) : base(nombre)
        {
        }
        public int _tailleMaxTerres
		{
			get { return tailleMaxTerres; }
			set { tailleMaxVerre = value;}	
        }
        public int _tailleMaxVerre
        {
            get { return tailleMaxVerre; }
			set { tailleMaxVerre = value; }
        }
        public int _tailleMaxPlastique
        {
            get { return tailleMaxPlastique; }
			set { tailleMaxVerre = value; }
        }
        public int _tailleMaxFeraille
        {
            get { return tailleMaxFeraille; }
			set { tailleMaxFeraille = value; }
        }
		public int _tailleMaxPapier
		{
			get { return tailleMaxPapier; }
			set { tailleMaxPapier = value; }
		}
        int tailleMaxPapier = 3067;
        int tailleMaxVerre = 2456;
        int tailleMaxPlastique = 561;
        int tailleMaxFeraille = 2658;
        int tailleMaxTerres = 8234;
    }
}