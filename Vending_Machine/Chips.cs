using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Chips : IProducts
    {
        public void Description()
        {
            Console.WriteLine("Öppna paketet och ät den bara fan !");
        }

        public string Name()
        {
            string name = "Chips för chubby. ";
            return name ;
        }

        public int Price()
        {
            return 15;
        }
    }
}
