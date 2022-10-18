using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Dricka : Product
    {
        public Dricka(int price, string name, string description) : base(price, name, description)
        {


        }
        public override void Use()
        {
            Console.WriteLine($"du dricker den {Name}");
        }
    }
}

