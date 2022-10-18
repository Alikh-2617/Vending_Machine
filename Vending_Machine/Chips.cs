using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Chips : Product
    {
        public Chips(int price, string name, string description) : base(price, name, description)
        {


        }
        public override void Use()
        {
            Console.WriteLine($"Du äter den {Name}. Knaprigt och gött!");
        }
    }
}
