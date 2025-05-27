using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        public string name;
        public int codeName;
        public string[] gear;
        public string status;
        public Commando(string name, int codeName, string gear, string status)
        {
            this.name = name;
            this.codeName = codeName;
            this.gear = new string[5] { "Hammer", "chisel", "rope", "bag", "water" };
            this.status = "standing";
        }
        public void Walk()
        {
            status = "walking";
            Console.WriteLine($"The soldier {name} is {status}");
        }
        public void Hide()
        {
            status = "hiding";
            Console.WriteLine($"The soldier {name} is {status}");
        }
        public void Attack()
        {
            Console.WriteLine($"The soldier {name} the codname is {codeName}");
        }
    }
}
