using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class BuyList
    {
        private List<IProducts> list = new List<IProducts>();

        IProducts sandwich = new Sandwich();
        IProducts chips = new Chips();  
        IProducts dricka = new Dricka();

        public void Show_list()
        {
            Console.WriteLine("Hej, här är lista över varor med pricet :");
            Console.WriteLine(" 1- "+sandwich.Name() +"  : "+ sandwich.Price()+" kr");
            Console.WriteLine(" 2- " + chips.Name() + "  : " + chips.Price() + " kr");
            Console.WriteLine(" 3- " + dricka.Name() + " : " + dricka.Price() + " kr");
            Console.WriteLine(" 4- Avsluta programmet och få tillbaka pengarna.");
            Console.Write("\n\nVilken vill du köpa : ");
            //int i = Get_Int();
            //switch (i)
            //{
            //    case 1:
            //        list.Add(sandwich);
            //        break;
            //    case 2:
            //        list.Add(chips);
            //        break;
            //    case 3:
            //        list.Add(dricka);
            //        break;
            //    case 4:
            //        break;
            //    default:
            //        Console.WriteLine("hände något fel , försökt igen !");
            //        break;
            //}
        }

        public void Buying(IProducts product)
        {
            list.Add(product);
        }

        public void Show_Buyed_list()
        {
            foreach (var item in list)
            {
                Console.Write(item.Name() +"\t : "+ item.Price());
            }
        }


        public int Totalt_price()
        {
            int totalt_price = 0;
             foreach (var item in list)
            {
                totalt_price += item.Price();
            }

            return totalt_price;
        }

        public int Get_Int()
        {
            int svar = 0;
            bool run = true;
            while (true)
            {
                Console.Write(" ==> : ");
                try
                {
                    svar = Convert.ToInt32(Console.ReadLine());
                    run = false;
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"fel typ av input !\nMeddelandet ( {e.Message} )");
                }
            }
            return svar;
        }


    }
}
