


namespace Vending_Machine
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i ;
            bool run = true;
            VendingMachine machine = new VendingMachine();
            machine.SetMoney();
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Hej här är Menu : ");
                machine.ShowAll();
                machine.GetMoney();
                machine.ShowBuyedList();
                i = machine.Get_Int();
                switch (i)
                {
                    case 1:
                        machine.InsertMoney(machine.Get_Int());
                        break;
                    case 2:
                        machine.EndTransaction();
                        run = false;
                        break;
                    case 3:
                        machine.Cancel();
                        run = false;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        machine.Purchase(i, machine.CheckMoney());
                        break;
                    default:
                        Console.WriteLine("Fel val , Försök igen !");
                        break;
                }
            }
        }
    }
}