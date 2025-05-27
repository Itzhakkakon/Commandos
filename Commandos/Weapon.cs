using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string name;
        public string manufacturer;
        public int numberOfBalls;

        public Weapon(string name, string manufacturer, int numberOfBalls)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.numberOfBalls = numberOfBalls;
        }
        public void Shoot()
        {
            numberOfBalls--;
            Console.WriteLine("shot");
        }
    }
}

