using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public abstract class Product
    {
        public Product(int price, string name, string description)
        {
            Price = price;
            Name = name;
            Description = description;
        }

        public int Price { get; }
        public string Name { get;  }
        public string Description { get;  }
        public abstract void Use();
        public virtual string Examine()
        {
            return $"Product name: {Name}, price: {Price} , Description : {Description}";
        }





    }
}
