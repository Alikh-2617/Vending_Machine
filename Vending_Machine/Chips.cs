using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Chips : IProducts
    {
        public object Description()
        {
            return "Öppna paketet och ät den bara fan !";
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
