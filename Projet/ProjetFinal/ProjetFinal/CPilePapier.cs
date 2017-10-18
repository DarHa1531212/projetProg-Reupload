using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CPilePapier
    {
        Stack pile = new Stack();

        public Stack _Pile
        {
            get { return pile; }
        }
        public void AjouterChainonPapier(int QMatierre)
        {
            pile.Push(QMatierre);
        }
        public int EnleverChainonPapier()
        {
            int top = Convert.ToInt32(pile.Peek());
            pile.Pop();
            return top;
        }
    }
}