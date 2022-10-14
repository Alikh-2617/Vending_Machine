using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class BuyList
    {
        MoneyManager moneyManager = new MoneyManager();
        IProducts sandwich = new Sandwich();
        IProducts chips = new Chips();
        IProducts dricka = new Dricka();

        List<IProducts> list = new List<IProducts>();
        


        public int Totalt_price(List<IProducts> list)
        {
            int totalt_price = 0;
            foreach (var item in list)
            {
                totalt_price += item.Price();
            }

            return totalt_price;
        }



        public void Show_Buyed_list(List<IProducts> list)
        {
            Console.Write("[");
            foreach (var item in list)
            {
                Console.Write("("+item.Name() + ": " + item.Price()+") ,");
            }
            Console.WriteLine("]\n\t\t\t\t\t\t\t Totalt price : " + Totalt_price(list));
        }



        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hej, här är lista över varor med pricet :\n" +
                              "---------------------------------------------\n");
            Console.WriteLine(" 1- " + sandwich.Name() + "  : " + sandwich.Price() + " kr");
            Console.WriteLine(" 2- " + chips.Name() + "  : " + chips.Price() + " kr");
            Console.WriteLine(" 3- " + dricka.Name() + " : " + dricka.Price() + " kr");
            Console.WriteLine(" 4- Sätta mer pengar . ");
            Console.WriteLine(" 5- Avsluta programmet och få tillbaka pengarna.\n" +
                              "---------------------------------------------------");
            Console.WriteLine("\n\nDin köp val : ");
        }

        public void Show_list()
        {
            int money = 0;
            bool run = true;
            moneyManager.SetMoney(ref money);

            while (run)
            {
                Menu();
                Show_Buyed_list(list);
                moneyManager.GetMoney(ref money);
                int i = moneyManager.Get_Int();
                                
                switch (i)
                {
                    case 1:
                        list.Add(sandwich);
                        run = moneyManager.CheckMoney(Totalt_price(list) , ref money);
                        break;
                    case 2:
                        list.Add(chips);
                        run = moneyManager.CheckMoney(Totalt_price(list), ref money);
                        break ;
                    case 3:
                        list.Add(dricka);
                        run = moneyManager.CheckMoney(Totalt_price(list), ref money);
                        break;
                    case 4:

                        // check current money gonna show !! 

                        moneyManager.SetMorMoney(ref money , Totalt_price(list));
                        break;

                    case 5:
                        Console.Clear();
                        moneyManager.ReturnLeftMoney(ref money);
                        Console.WriteLine("Tack för besök. tryck inter för att avsluta prgrammet ");
                        list.Clear();
                        Console.ReadKey();
                        run = false;
                        continue;

                    default:
                        Console.Clear();
                        Console.WriteLine("Fel val !\n\nTryck inter för att komma till Menu igen !");
                        Console.ReadKey();
                        continue;

                }
            }

        }










    }
}
