﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjetFinal
{
    class CPileTerre
    {
        Stack pile = new Stack();

        public Stack _Pile
        {
            get { return pile; }
        }
        public void AjouterChainonTerre(int QMatierre)
        {
            pile.Push(QMatierre);
        }
        public int EnleverChainonTerre()
        {
            int top = Convert.ToInt32(pile.Peek());
            pile.Pop();
            return top;
        }
    }
}