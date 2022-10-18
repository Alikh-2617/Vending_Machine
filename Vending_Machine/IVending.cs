using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal interface IVending
    {
        public void Purchase(int choice , bool haveMoney);
        public void ShowAll();    
        public void InsertMoney (int money1); 
        public void EndTransaction(); 
    }
}
