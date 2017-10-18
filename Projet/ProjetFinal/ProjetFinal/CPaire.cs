using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CPaire : CCentreTri
    {
        public CPaire(int nombre) : base(nombre)
        { }
        public int _tailleMaxTerres
        {
            get { return tailleMaxTerres; }
			set { tailleMaxTerres = value; }
        }
        public int _tailleMaxVerre
        {
            get { return tailleMaxVerre; }
			set { tailleMaxVerre = value; }
        }
        public int _tailleMaxPlastique
        {
            get { return tailleMaxPlastique; }
			set { tailleMaxPlastique = value; }
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
        int tailleMaxPapier = 1003;
        int tailleMaxVerre = 857;
        int tailleMaxPlastique = 3456;
        int tailleMaxFeraille = 457;
        int tailleMaxTerres = 639;
    }
}