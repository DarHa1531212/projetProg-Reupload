using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjetFinal
{
    class CSimulation
    {
        int qteVaisseaux, qteCentresTri;
        CCentreTri ancre, queue, actuel, precedent;
        int i;
        PrimeTool prime = new PrimeTool();
        CAffichage Affichege1 = new CAffichage();
        public void ChoixTailleSIM()
        {//Choix taille simulation
            string choixTaille = "veuillez choisir la taille de votre simulation:";
            Affichege1.afficherClear(choixTaille);
            Affichege1.afficherSansClear(choixTaille = " 1 - 10 centres de tri ");
            Affichege1.afficherSansClear(choixTaille = " 2 - 20 centres de tri ");
            Affichege1.afficherSansClear(choixTaille = " 3 - 30 centres de tri ");
            Affichege1.afficherSansClear(choixTaille = " 4 - 40 centres de tri ");
            Affichege1.afficherSansClear(choixTaille = " 5 - 50 centres de tri ");
            Affichege1.afficherSansClear(choixTaille = "Votre choix:");
            int choix =(Convert.ToInt32( Console.ReadLine()))*10;
            qteCentresTri = choix;
            Affichege1.afficherClear(choixTaille = " 1 - 100 vaisseaux ");
            Affichege1.afficherSansClear(choixTaille = " 2 - 200 vaisseaux ");
            Affichege1.afficherSansClear(choixTaille = " 3 - 300 vaisseaux ");
            Affichege1.afficherSansClear(choixTaille = " 4 - 400 vaisseaux ");
            Affichege1.afficherSansClear(choixTaille = " 5 - 500 vaisseaux ");
            Affichege1.afficherSansClear(choixTaille = "Votre choix:");
            choix = (Convert.ToInt32(Console.ReadLine()))*100;
            qteVaisseaux = choix;
            CreerStation();
        }
        public void CreerStation()
        {//boucle creation centre de tri
            for (i = 0; i < qteCentresTri; i++)
            {

                if (i % 2 == 0)
                {
                    CPaire centreTri = new CPaire(i);

                    //centre de tri paire
                    if (i == 0)
                    {
                        actuel = centreTri;
                        ancre = actuel;
                        queue = actuel;
                    }
                    else
                    {
                        actuel._Suivant = centreTri;
                        precedent = actuel;
                        actuel = centreTri;
                        queue = actuel;
                    }
                    // verif nombre premier et multiple de cinq 
                    VerifPaire(centreTri);

                }

                else if (i % 2 == 1)
                {
                    CImpaire centreTri = new CImpaire(i);
                    actuel._Suivant = centreTri;
                    actuel = centreTri;
                    queue = actuel;
                    // verif nombre premier et multiple de cinq 
                    VerifImpaire(centreTri);
                }
            }
            debutSim();
        }
        public void VerifImpaire(CImpaire station)
        {
            bool premier = prime.IsPrime(i);
            if (premier == true)
            {
                //ne recoivent que de la feraille et du plastique
                station._tailleMaxPapier = 0;
                station._tailleMaxTerres = 0;
                station._tailleMaxVerre = 0;
            }
            if (i % 5 == 0)
            {
                station._tailleMaxFeraille = 0;
                station._tailleMaxPapier = 0;
                station._tailleMaxPlastique = 0;
            }
        }
        public void VerifPaire(CPaire station)
        {
            bool premier = prime.IsPrime(i);
            if (premier == true)
            {
                //ne recoivent que de la feraille et du plastique
                station._tailleMaxPapier = 0;
                station._tailleMaxTerres = 0;
                station._tailleMaxVerre = 0;
            }

            if (i % 5 == 0)
            {
                station._tailleMaxFeraille = 0;
                station._tailleMaxPapier = 0;
                station._tailleMaxPlastique = 0;
            }
        }
        public void debutSim()
        {//appel des fonctions de la simulation
            actuel = ancre;
            ancre.creerVaisseaux(qteVaisseaux);
            gererCentreTri();
        }
        public void RemplirVaisseauStationTri(int Materiel)//choix de matiere a transferer
        {
            int QMatierre;
            switch (Materiel)
            {  //transferer autant de bloc de matierre que possible vers un vaisseau
                case 1:
                    //tant et aussi longtemps que le vaisseau a dla place pour un autre bloc
                    while (true)
                    {//si centre de tri est vide
                        if (actuel._PileFerraille._Pile == null)
                            break;
                        else
                        {//vider le premier bloc de matierre dans le vaisseau si il y a de la place libre sinon break
                            QMatierre = actuel._PileFerraille.EnleverChainonFerraille();
                            if (QMatierre > actuel._FileDepart._Ancre._QteMax - (actuel._FileDepart._Ancre._QteFerraille + actuel._FileDepart._Ancre._QtePapier + actuel._FileDepart._Ancre._QtePlastique + actuel._FileDepart._Ancre._QteTerre + actuel._FileDepart._Ancre._QteVerre))
                            {
                                actuel._PileFerraille.AjouterChainonFerraille(QMatierre);
                                break;
                            }
                            actuel._tailleActuFeraille = actuel._tailleActuFeraille - QMatierre;
                            actuel._FileDepart._Ancre._QteFerraille = QMatierre;
                        }
                    }
                    break;
                case 2:
                    while (true)
                    {
                        if (actuel._PileFerraille._Pile == null)
                            break;
                        else
                        {
                            QMatierre = actuel._PileVerre.EnleverChainonVerre();
                            if (QMatierre > actuel._FileDepart._Ancre._QteMax - (actuel._FileDepart._Ancre._QteFerraille + actuel._FileDepart._Ancre._QtePapier + actuel._FileDepart._Ancre._QtePlastique + actuel._FileDepart._Ancre._QteTerre + actuel._FileDepart._Ancre._QteVerre))
                            {
                                actuel._PileVerre.AjouterChainonVerre(QMatierre);
                                break;
                            }
                            actuel._tailleActuVerre = actuel._tailleActuVerre - QMatierre;
                            actuel._FileDepart._Ancre._QteVerre = QMatierre;
                        }
                    }
                        break;
                case 3:
                    while (true)

                    {
                        if (actuel._PileFerraille._Pile == null)
                            break;
                        else
                        {
                            QMatierre = actuel._PileTerre.EnleverChainonTerre();
                        if (QMatierre > actuel._FileDepart._Ancre._QteMax - (actuel._FileDepart._Ancre._QteFerraille + actuel._FileDepart._Ancre._QtePapier + actuel._FileDepart._Ancre._QtePlastique + actuel._FileDepart._Ancre._QteTerre + actuel._FileDepart._Ancre._QteVerre))
                        {
                            actuel._PileTerre.AjouterChainonTerre(QMatierre);
                            break;
                        }
                        actuel._tailleActuTerres = actuel._tailleActuTerres - QMatierre;
                        actuel._FileDepart._Ancre._QteTerre = QMatierre;
                    } 
                            }
                    break;
                case 4:
                    while (true)
                    {
                        if (actuel._PileFerraille._Pile == null)
                            break;
                        else
                        {
                            QMatierre = actuel._PilePlastique.EnleverChainonPlastique();
                            if (QMatierre > actuel._FileDepart._Ancre._QteMax - (actuel._FileDepart._Ancre._QteFerraille + actuel._FileDepart._Ancre._QtePapier + actuel._FileDepart._Ancre._QtePlastique + actuel._FileDepart._Ancre._QteTerre + actuel._FileDepart._Ancre._QteVerre))
                            {
                                actuel._PilePlastique.AjouterChainonPlastique(QMatierre);
                                break;
                            }
                            actuel._tailleActuPlastique = actuel._tailleActuPlastique - QMatierre;
                            actuel._FileDepart._Ancre._QtePlastique = QMatierre;
                        }
                    }
                    break;
                case 5:
                    while (true)
                    {
                        if (actuel._PileFerraille._Pile == null)
                            break;
                        else
                        {
                            QMatierre = actuel._PilePapier.EnleverChainonPapier();
                            if (QMatierre > actuel._FileDepart._Ancre._QteMax - (actuel._FileDepart._Ancre._QteFerraille + actuel._FileDepart._Ancre._QtePapier + actuel._FileDepart._Ancre._QtePlastique + actuel._FileDepart._Ancre._QteTerre + actuel._FileDepart._Ancre._QteVerre))
                            {
                                actuel._PilePlastique.AjouterChainonPlastique(QMatierre);
                                break;
                            }
                            actuel._tailleActuPapier = actuel._tailleActuPapier - QMatierre;
                            actuel._FileDepart._Ancre._QtePapier = QMatierre;
                        }
                    }
                    break;
            } //envoie le vaisseau rempli dans la file d'arrivé du prochain centre de tri
            EnvoyerSuivant();

        }
        public int ViderVaisseau()
        {
            //end my suffering

            int plein;
            plein = 0;
            //verifie si la quantite contenu dans le vaisseau excede l'espace libre dans le centre de tri
            //dans le cas d'un centre de tri paire
            if (actuel is CPaire)
            {

                if (((CPaire)actuel)._tailleMaxPapier - ((CPaire)actuel)._tailleActuPapier < actuel._FileArrive._Ancre._QtePapier && ((CPaire)actuel)._tailleMaxPapier != 0)
                    plein = 5;

                if (((CPaire)actuel)._tailleMaxVerre - ((CPaire)actuel)._tailleActuVerre < actuel._FileArrive._Ancre._QteVerre && ((CPaire)actuel)._tailleMaxVerre != 0)
                    plein = 2;

                if (actuel._FileArrive._Ancre._QtePlastique > ((CPaire)actuel)._tailleMaxPlastique - ((CPaire)actuel)._tailleActuPlastique && ((CPaire)actuel)._tailleMaxPlastique != 0)
                    plein = 4;

                if (actuel._FileArrive._Ancre._QteFerraille > ((CPaire)actuel)._tailleMaxFeraille - ((CPaire)actuel)._tailleActuFeraille && ((CPaire)actuel)._tailleMaxFeraille != 0)
                    plein = 1;

                if (actuel._FileArrive._Ancre._QteTerre > ((CPaire)actuel)._tailleMaxTerres - ((CPaire)actuel)._tailleActuTerres && ((CPaire)actuel)._tailleMaxTerres != 0)
                    plein = 3;

            }
            else    // dans le cas d'un centre de tri impaire
            {
                if (actuel._FileArrive._Ancre._QtePapier > ((CImpaire)actuel)._tailleMaxPapier - ((CImpaire)actuel)._tailleActuPapier && ((CImpaire)actuel)._tailleMaxPapier != 0)
                    plein = 5;


                if (actuel._FileArrive._Ancre._QteVerre > ((CImpaire)actuel)._tailleMaxVerre - ((CImpaire)actuel)._tailleActuVerre && ((CImpaire)actuel)._tailleMaxVerre != 0)
                    plein = 2;

                if (actuel._FileArrive._Ancre._QtePlastique > ((CImpaire)actuel)._tailleMaxPlastique - ((CImpaire)actuel)._tailleActuPlastique && ((CImpaire)actuel)._tailleMaxPlastique != 0)
                    plein = 4;

                if (actuel._FileArrive._Ancre._QteFerraille > ((CImpaire)actuel)._tailleMaxFeraille - ((CImpaire)actuel)._tailleActuFeraille && ((CImpaire)actuel)._tailleMaxFeraille != 0)
                    plein = 1;


                if (actuel._FileArrive._Ancre._QteTerre > ((CImpaire)actuel)._tailleMaxTerres - ((CImpaire)actuel)._tailleActuTerres && ((CImpaire)actuel)._tailleMaxTerres != 0)
                    plein = 3;

            }
            if (plein == 0)    //si le centre de tri n'est pas plein, vider le vaisseau dans le centre de tri
            {//dans le cas d'un centre de tri paire
                if (actuel is CPaire)
                {
                    if (((CPaire)actuel)._tailleMaxFeraille != 0)
                    {//décharher le feraille
                        ViderVaisseauStationTri(1, actuel._FileArrive._Ancre._QteFerraille);
                    }
                    if (((CPaire)actuel)._tailleMaxVerre != 0)
                    {//décharher le verre
                        ViderVaisseauStationTri(2, actuel._FileArrive._Ancre._QteVerre);
                    }
                    if (((CPaire)actuel)._tailleMaxTerres != 0)
                    {//décharher le terre
                        ViderVaisseauStationTri(3, actuel._FileArrive._Ancre._QteTerre);
                    }
                    if (((CPaire)actuel)._tailleMaxPlastique != 0)
                    {//décharher le plastique
                        ViderVaisseauStationTri(4, actuel._FileArrive._Ancre._QtePlastique);
                    }
                    if (((CPaire)actuel)._tailleMaxPapier != 0)
                    {//décharher le papier
                        ViderVaisseauStationTri(5, actuel._FileArrive._Ancre._QtePapier);
                    }
                }
                else //dans le cas d'un centre de tri impaire
                {
                    if (((CImpaire)actuel)._tailleMaxFeraille != 0)
                    {//décharher le feraille
                        ViderVaisseauStationTri(1, actuel._FileArrive._Ancre._QteFerraille);
                    }
                    if (((CImpaire)actuel)._tailleMaxVerre != 0)
                    {//décharher le verre
                        ViderVaisseauStationTri(2, actuel._FileArrive._Ancre._QteVerre);
                    }
                    if (((CImpaire)actuel)._tailleMaxTerres != 0)
                    {//décharher le terre
                        ViderVaisseauStationTri(3, actuel._FileArrive._Ancre._QteTerre);
                    }
                    if (((CImpaire)actuel)._tailleMaxPlastique != 0)
                    {//décharher le plastique
                        ViderVaisseauStationTri(4, actuel._FileArrive._Ancre._QtePlastique);
                    }
                    if (((CImpaire)actuel)._tailleMaxPapier != 0)
                    {//décharher le papier
                        ViderVaisseauStationTri(5, actuel._FileArrive._Ancre._QtePapier);
                    }
                }//envoyer les vaisseaux vidés dans les files de sorti d'un centre de tri
                StockerFileSortie();
            }
            return plein;
        }
        public void ViderVaisseauStationTri(int Materiel, int QteMateriel)
        {//vider le contenu du vaisseau dans le centre de tri
            switch (Materiel)
            {
                case 1:
                    actuel._tailleActuFeraille = actuel._tailleActuFeraille + actuel._FileArrive._Ancre._QteFerraille;
                    actuel._PileFerraille.AjouterChainonFerraille(QteMateriel);
                    break;
                case 2:
                    actuel._tailleActuVerre = actuel._tailleActuVerre + actuel._FileArrive._Ancre._QteVerre;
                    actuel._PileVerre.AjouterChainonVerre(QteMateriel);
                    break;
                case 3:
                    actuel._tailleActuTerres = actuel._tailleActuTerres + actuel._FileArrive._Ancre._QteTerre;
                    actuel._PileTerre.AjouterChainonTerre(QteMateriel);
                    break;
                case 4:
                    actuel._tailleActuPlastique = actuel._tailleActuPlastique + actuel._FileArrive._Ancre._QtePlastique;
                    actuel._PilePlastique.AjouterChainonPlastique(QteMateriel);
                    break;
                case 5:
                    actuel._tailleActuPapier = actuel._tailleActuPapier + actuel._FileArrive._Ancre._QtePapier;
                    actuel._PilePapier.AjouterChainonPapier(QteMateriel);
                    break;
            }
        }
        public void EnvoyerSuivant()
        {//envoyer un vaisseau vers un centre de tri suivant
            //si le centre de tri n'est pas le dernier
            if (actuel._Suivant != null)
            {
                actuel._Suivant._FileArrive.AjouterChainonArrive(actuel._FileDepart._Ancre);
            }
            actuel._FileDepart.EnleverChainonDepart(actuel._FileDepart._Ancre);
        }
        public void StockerFileSortie()
        { //envoyer un vaisseau d'une file d'arriver a une file de sortie
            actuel._FileArrive.EnleverChainonArrive(actuel._FileArrive._Ancre);
            actuel._FileDepart.AjouterChainonDepart(actuel._FileArrive._Ancre);
        }
        public void AfficherCentreTRiVaisseau()
        {
            actuel = ancre;
            while (actuel._Suivant != null)
            {
                Affichege1.afficherClear(actuel._tailleActuFeraille.ToString() + " qte fer " + actuel._tailleActuPapier.ToString() + " qte papier " + actuel._tailleActuPlastique.ToString() + " qte plastique " + actuel._tailleActuTerres.ToString() + " qte terre " + actuel._tailleActuVerre.ToString() + " qte verre ");
                actuel = actuel._Suivant;
            }
        }
        public void gererCentreTri()
        {//appel en boucle les fonctions pour vider et remplir les vaisseaux et centre de tri
            //contient la boucle pour passer d'un centre a un autre
            int finiRemplir = 0;
            //quand finir remplire est true, il faut vider la station
            while (actuel._Suivant != null)
            {
                while (actuel._FileArrive._Ancre != null)
                {
                    while (finiRemplir == 0)
                    {
                        finiRemplir = ViderVaisseau();
                    }
                    RemplirVaisseauStationTri(finiRemplir);
                }
                actuel = actuel._Suivant;
            }
            AfficherCentreTRiVaisseau();
        }
    }
}