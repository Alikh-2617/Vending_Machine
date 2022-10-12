using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class Sandwich : IProducts
    {
        public void Description()
        {
            Console.WriteLine("bara ät den , så enkelt !");

        }

        public string Name()
        {
            string name = "Smörgås";
            return name;
        }

        public int Price()
        {
            return 25;
        }
    }
}
