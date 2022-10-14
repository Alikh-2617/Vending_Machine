using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class MoneyManager : Money
    {

        public override void GetMoney(ref int money)
        {
            Console.WriteLine($"\t\t\t\t\t\t\t Din Saldo är : {money} Kr");
        }

        public override void SetMoney(ref int money)
        {
            Console.WriteLine("Hej här kan du sätta pengar : ");
            money = Get_Int();
        }

        public override void SetMorMoney(ref int money , int totaltprice)
        {
            Console.Clear();
            Console.WriteLine("Hej, här kan du sätta pengar i din saldo : ");
            Console.Write("\n------------------------\n" +
                              "\nDin saldo           : "+ money +
                              "\nTotalt inköpt belopp: " + totaltprice +
                              "\nTillgängligt saldo  : "+ (money - totaltprice) +

                              "\n\nTilllägg pengar");
            money += Get_Int();
        }

        public bool CheckMoney( int totalPrice , ref int money )
        {
            bool check = true;
            Console.Clear();    
            if (totalPrice > money)
            {
                Console.WriteLine("Du har inte tillräckligt pengar vill du sätta pengar ? 1 ja // 2 nej avsluta.");
                int i = Get_Int();
                if(i == 1)
                {
                    SetMorMoney(ref money , totalPrice);
                }
                else
                {
                    Console.WriteLine("tryck Enter föratt få dina pengarna till baka.");
                    Console.ReadKey();
                    ReturnLeftMoney(ref money);
                    Console.WriteLine("tryck Enter föratt avsluta.");
                    Console.ReadKey();
                    check = false;
                }
                
            }

            return check;
        }


        public void ReturnLeftMoney(ref int money)
        {
            string[] myList = new string[] { "", "", "0", "00", "000", "0000" };
            int[] list = new int[] { 1, 5, 10, 20, 50, 100, 200, 500, 1000 };
            Dictionary<int, int> returnManey = new Dictionary<int, int>();

            string s = money.ToString();
            char[] positions = s.ToCharArray();
            int lenght = positions.Length;
            int bb = lenght;
            int index = 0;

            for (int i = 0; i < lenght; i++)
            {
                int b = int.Parse(positions[i].ToString());
                string b1 = b + myList[bb];
                int b2 = Convert.ToInt32(b1);
                if (list.Contains(b2))
                {
                    if (b2 != 0)
                    {
                        returnManey.Add(index, b2);
                        index++;

                        bb--;

                        continue;
                    }
                }
                else
                {
                    int d1 = b - 1;
                    string d2 = d1 + myList[bb];
                    int d3 = Convert.ToInt32(d2);
                    if (list.Contains(d3))
                    {
                        if (d3 != 0)
                        {
                            string d4 = 1 + myList[bb];
                            int d5 = Convert.ToInt32(d4);

                            returnManey.Add(index, d3);
                            index++;
                            returnManey.Add(index, d5);
                            index++;
                            bb--;
                            continue;
                        }
                    }
                    else
                    {
                        int c1 = d1 - 1;
                        string c2 = c1 + myList[bb];
                        int c3 = Convert.ToInt32(c2);
                        if (list.Contains(c3))
                        {
                            if (c3 != 0)
                            {
                                string c4 = 2 + myList[bb];
                                int c5 = Convert.ToInt32(c4);

                                if (list.Contains(c5))
                                {
                                    returnManey.Add(index, c3);
                                    index++;
                                    returnManey.Add(index, c5);
                                    index++;
                                    bb--;
                                    continue;
                                }
                                else
                                {
                                    string c6 = 1 + myList[bb];
                                    string c7 = 1 + myList[bb];

                                    int c8 = Convert.ToInt32(c6);
                                    int c9 = Convert.ToInt32(c7);

                                    returnManey.Add(index, c3);
                                    index++;
                                    returnManey.Add(index, c8);
                                    index++;
                                    returnManey.Add(index, c9);
                                    index++;
                                    bb--;
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            int f1 = c1 - 1;
                            string f2 = f1 + myList[bb];
                            int f3 = Convert.ToInt32(f2);
                            if (list.Contains(f3))
                            {
                                if (f3 != 0)
                                {
                                    string f4 = 2 + myList[bb];
                                    string f5 = 1 + myList[bb];

                                    int f6 = Convert.ToInt32(f4);
                                    int f7 = Convert.ToInt32(f5);

                                    if (list.Contains(f6))
                                    {
                                        returnManey.Add(index, f3);
                                        index++;
                                        returnManey.Add(index, f6);
                                        index++;
                                        returnManey.Add(index, f7);
                                        index++;
                                        bb--;
                                        continue;

                                    }
                                    else
                                    {
                                        string f8 = 1 + myList[bb];
                                        string f9 = 1 + myList[bb];
                                        string f10 = 1 + myList[bb];

                                        int f11 = Convert.ToInt32(f8);
                                        int f12 = Convert.ToInt32(f9);
                                        int f13 = Convert.ToInt32(f10);


                                        returnManey.Add(index, f3);
                                        index++;
                                        returnManey.Add(index, f11);
                                        index++;
                                        returnManey.Add(index, f12);
                                        index++;
                                        returnManey.Add(index, f13);
                                        index++;
                                        bb--;
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                int s1 = f1 - 1;
                                string s2 = s1 + myList[bb];
                                int s3 = Convert.ToInt32(s2);
                                if (list.Contains(s3))
                                {
                                    if (s3 != 0)
                                    {
                                        string s4 = 2 + myList[bb];
                                        string s5 = 2 + myList[bb];

                                        int s6 = Convert.ToInt32(s4);
                                        int s7 = Convert.ToInt32(s5);

                                        if (list.Contains(s6))
                                        {
                                            returnManey.Add(index, s3);
                                            index++;
                                            returnManey.Add(index, s6);
                                            index++;
                                            returnManey.Add(index, s7);
                                            index++;
                                            bb--;
                                            continue;

                                        }
                                        else
                                        {
                                            string s8 = 1 + myList[bb];
                                            string s9 = 1 + myList[bb];
                                            string s10 = 1 + myList[bb];
                                            string s11 = 1 + myList[bb];

                                            int s12 = Convert.ToInt32(s8);
                                            int s13 = Convert.ToInt32(s9);
                                            int s14 = Convert.ToInt32(s10);
                                            int s15 = Convert.ToInt32(s11);



                                            returnManey.Add(index, s3);
                                            index++;
                                            returnManey.Add(index, s12);
                                            index++;
                                            returnManey.Add(index, s13);
                                            index++;
                                            returnManey.Add(index, s14);
                                            index++;
                                            returnManey.Add(index, s15);
                                            index++;
                                            bb--;
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }



            Console.Write("Return Money ==> [ ");
            foreach (KeyValuePair<int, int> item in returnManey)
            {
                Console.Write(item.Value);
                if (item.Key + 1 < returnManey.Count) { Console.Write(", "); }
            }
            Console.WriteLine(" ]\n\n\n\n");
        }




    }
}
