namespace Vending_Machine
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();    
                Console.WriteLine("Hej tryck inter att börja handla.");
                Console.WriteLine("\n\n\n   ======= > HÄR < =======");
                Console.ReadKey();
                Console.Clear();
                BuyList runNow = new BuyList();
                runNow.Show_list();
            }
        }
    }
}