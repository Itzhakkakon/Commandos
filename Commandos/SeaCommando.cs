﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string gear, string status)
            : base(name, codeName, gear, status)
        {
        }
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
        public override void Attack()
        {
            Console.WriteLine("Marine commando attacks!");
        }
    }
}