using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Dricka : IProducts
    {
        public void Description()
        {
            Console.WriteLine("Dick upp den om du är inte klock !");
        }

        public string Name()
        {
            string name = "Dicka för törstiga";
            return name ;
        }

        public int Price()
        {
            return 10;
        }
    }
}

