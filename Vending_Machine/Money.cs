using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public abstract class Money
    {
        public List<int> monyList = new List<int> { 1, 5, 10, 20, 50, 100, 200, 500, 1000 };


        public abstract void GetMoney(ref int money);
        public abstract void SetMoney(ref int money);
        public abstract void SetMorMoney(ref int money , int totalprice);
        public virtual int Get_Int()
        {
            int i = 0;
            bool run = true;
            while (run)
            {
                Console.Write(" ==> : ");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    run = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine($"fel meddelande : {e.Message}");
                }
            }
            return i;
        }







    }
}
