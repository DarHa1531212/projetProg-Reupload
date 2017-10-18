using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CCentreTri
    {// taille maximaele
        public CCentreTri(int _noCentre)
        {
			noCentre = _noCentre;
		}
        CPileVerre PileVerre = new CPileVerre();
        CPileTerre PileTerre = new CPileTerre();
        CPilePapier PilePapier = new CPilePapier();
        CPileFerraille PileFerraille = new CPileFerraille();
        CPilePlastique PilePlastique = new CPilePlastique();
        int noCentre;
        int tailleActuPapier = 0;
        int tailleActuVerre = 0;
        int tailleActuPlastique = 0;
        int tailleActuFeraille = 0;
        int tailleActuTerres = 0;
        CFileArrivee FileArrivee = new CFileArrivee();
        CFileDepart FileDepart = new CFileDepart();
        CCentreTri suivant, precedant;
        public CPileVerre _PileVerre
        {
            get { return PileVerre; }
        }
        public CPileTerre _PileTerre
        {
            get { return PileTerre; }
        }
        public CPilePapier _PilePapier
        {
            get { return PilePapier; }
        }
        public CPileFerraille _PileFerraille
        {
            get { return PileFerraille; }
        }
        public CPilePlastique _PilePlastique
        {
            get { return PilePlastique; }
        }
        public int _tailleActuPapier
        {
            get { return tailleActuPapier; }
            set { tailleActuPapier = value; }
        }
        public int _tailleActuVerre
        {
            get { return tailleActuVerre; }
            set { tailleActuVerre = value;}
        }
        public int _tailleActuPlastique
        {
            get { return tailleActuPlastique; }
            set { tailleActuPlastique = value; }
        }
        public int _tailleActuFeraille
        {
            get { return tailleActuFeraille; }
            set { tailleActuFeraille = value; }
        }
        public int _tailleActuTerres
        {
            get { return tailleActuTerres; }
            set { tailleActuTerres = value; }
        }
        public CCentreTri _Suivant
        {
            get { return suivant;}
            set { suivant = value; }
        }
        public CFileArrivee _FileArrive
        {
            get { return FileArrivee; }
        }
        public CFileDepart _FileDepart
        {
            get { return FileDepart; }
        }
        public CCentreTri _Precedent
        {
            get { return precedant; }
        }
        public void creerVaisseaux(int nbreVaisseaux)
        {
            for (int i = 0; i < nbreVaisseaux; i++)
            {
                if (CargoOuLeger() % 2 == 0)
                {
					//instancier un cargo
					CCargo vaisseau = new CCargo(0,0,0,0,0,0,null);
                    RemplirVaisseauStart(vaisseau);
                    FileArrivee.AjouterChainonArrive(vaisseau);
                }

                else if (CargoOuLeger() % 2 == 1)
                {
					//instancier un vaisseau léger
					CLeger vaisseau = new CLeger(0, 0, 0, 0, 0, 0, null);
                    RemplirVaisseauStart(vaisseau);
                    FileArrivee.AjouterChainonArrive(vaisseau);
                }
            }            
        }
        public int CargoOuLeger()
        { //random pour determiner le type de vaisseau
            Random Type = new Random();
            int nombre;
            nombre = Type.Next(1);
            return nombre;
        }
        private void RemplirVaisseauStart(CVaisseaux Vaisseau)
        {//remplissage initial des vaisseaux
            Random rndMatierre = new Random();
            int QVerre, QTerre, QFerraille, QPlastique,QPapier, Matierre, QReste, cptRemplie;
            bool Verre, Terre, Ferraille, Plastique,Papier;

            cptRemplie = 0;
            QReste = Vaisseau._QteMax;
            Verre = true;
            Terre = true;
            Ferraille = true;
            Plastique = true;
            Papier = true;
            QVerre = 0;
            QTerre = 0;
            QPlastique = 0;
            QFerraille = 0;
            QPapier = 0;

            while ((cptRemplie < 4)&&(QReste!=0))
            {
                Matierre = rndMatierre.Next(5);

                    switch (Matierre)
                    {
                        case 0:
                            if (Verre == true)
                            {
                             if(108<QReste)
                            {
                                QVerre = rndMatierre.Next(108);
                                QReste = QReste - QVerre;
                                Verre = false;
                                cptRemplie++;
                            }
                            else
                            {
                                QVerre = rndMatierre.Next(QReste - 1);
                                QReste = QReste - QVerre;
                                Verre = false;
                                cptRemplie++;
                            }
                            }
                            break;

                        case 1:
                            if (Terre == true)
                            {
                            if (108 < QReste)
                            {
                                QTerre = rndMatierre.Next(108);
                                QReste = QReste - QTerre;
                                Terre = false;
                                cptRemplie++;
                            }
                            else
                            {
                                QTerre = rndMatierre.Next(QReste - 1);
                                QReste = QReste - QTerre;
                                Terre = false;
                                cptRemplie++;
                            }

                            }
                            break;

                        case 2:
                            if (Ferraille == true)
                               {
                                if (108 < QReste)
                               {
                                  QFerraille = rndMatierre.Next(108);
                                  QReste = QReste - QFerraille;
                                  Ferraille = false;
                                  cptRemplie++;
                                }
                                 else
                                {
                                   QFerraille = rndMatierre.Next(QReste - 1);
                                   QReste = QReste - QFerraille;
                                   Ferraille = false;
                                   cptRemplie++;
                                }
                            }
                            break;

                        case 3:
                            if (Plastique == true)
                            {
                            if (108 < QReste)
                            {
                                QPlastique = rndMatierre.Next(108);
                                QReste = QReste - QPlastique;
                                Plastique = false;
                                cptRemplie++;
                            }
                            else
                            {
                                QPlastique = rndMatierre.Next(QReste - 1);
                                QReste = QReste - QPlastique;
                                Plastique = false;
                                cptRemplie++;
                            }
                            }
                            break;

                        default:
                            if (Papier == true)
                            {
                            if (108 < QReste)
                            {
                                QPapier = rndMatierre.Next(108);
                                QReste = QReste - QPapier;
                                Papier = false;
                                cptRemplie++;
                            }
                            else
                            {
                                QPapier = rndMatierre.Next(QReste - 1);
                                QReste = QReste - QPapier;
                                Papier = false;
                                cptRemplie++;
                            }
                            }
                            break;
                }
            }

            if (Plastique == true)
            {
                QPlastique = QReste;
            }
            else if (Ferraille == true)
            {
                QFerraille = QReste;
            }
            else if (Terre == true)
            {
                QTerre = QReste;
            }
            else if (Verre == true)
            {
                QVerre = QReste;
            }
            else if (Papier == true)
            {
                QPapier = QReste;
            }
            Vaisseau._QteFerraille = QFerraille;
            Vaisseau._QtePapier = QPapier;
            Vaisseau._QtePlastique = QPlastique;
            Vaisseau._QteTerre = QTerre;
            Vaisseau._QteVerre = QVerre;
        }
    }
}