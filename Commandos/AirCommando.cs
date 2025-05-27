using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codeName, string gear, string status)
            : base(name, codeName, gear, status)
        {
        }
        public void Parachute()
        {
            Console.WriteLine("Parachute");
        }
    }
}
