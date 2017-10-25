﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class NonSentient : Race
    {
        private bool tame;

        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }

        public NonSentient()
        {
        }

        public NonSentient(int str, int sta, string nam, bool tam): base(str,sta,nam)
        {
            Tame = tam;
        }

        public override string PrintRace()
        {
            string output = base.PrintRace();
            if (Tame)
            {
                output += ".\nThis is a tame";
            }
            else
            {
                output += ".\nThis is a wild";
            }
            return output;
        }

    }
}