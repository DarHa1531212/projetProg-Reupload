using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class CPileFerraille
    {
        Stack pile = new Stack();

        public Stack _Pile
        {
            get { return pile; }
        }
        public void AjouterChainonFerraille(int QMatierre)
        {
            pile.Push(QMatierre);
        }
        public int EnleverChainonFerraille( )
        {
            int top = Convert.ToInt32(pile.Peek());
            pile.Pop();
            return top;
        }
    }
}