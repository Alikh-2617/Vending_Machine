using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Sandwich : Product
    {
        public Sandwich(int price, string name, string description) : base(price, name, description)
        {


        }

        public override void Use()
        {
            Console.WriteLine($"Du äter {Name}");
        }

    }
}
