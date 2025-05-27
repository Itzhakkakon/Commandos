using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        private string name;
        public string CodeName { get; set; }
        public string[] gear;
        public string status;
        public Commando(string name, string codeName, string gear, string status)
        {
            this.name = name;
            this.CodeName = codeName;
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
        public virtual void Attack()
        {
            Console.WriteLine($"The soldier Attack!");
        }
        public void SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                Console.WriteLine($"name is {name}");
            }
            else if (commanderRank == "COLONEL")
            {
                Console.WriteLine($"The soldier's personal number is: {CodeName}");
            }
            else
            {
                Console.WriteLine("You are not authorized to see this information, it is classified information.");
            }
        }
    }
}
