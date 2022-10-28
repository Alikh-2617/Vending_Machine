using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Vending_Machine;

namespace TestProject1
{
    public class UnitTest1
    {
        Sandwich sandwich = new Sandwich(10, "bb", "ss");
        [Fact]
        public void SandwichTest()
        {
            Assert.Equal("bb", sandwich.Name);
            Assert.Equal(10, sandwich.Price);
            Assert.Equal("ss", sandwich.Description);
        }

        Dricka Dricka = new Dricka(15, "ii", "ww");
        [Fact]
        public void DrickaTest()
        {
            Assert.Equal("ii", Dricka.Name);
            Assert.Equal(15, Dricka.Price);
            Assert.Equal("ww", Dricka.Description);
        }

        Chips Chips = new Chips(20, "cc", "dd");
        [Fact]
        public void ChipsTest()
        {
            Assert.Equal("cc", Chips.Name);
            Assert.Equal(20, Chips.Price);
            Assert.Equal("dd", Chips.Description);

        }

        VendingMachine vendingMachine = new VendingMachine();

        [Fact]
        public void CheckForItemsTest()
        {
            Assert.True(vendingMachine.Products.Any());
            Assert.Equal(3, vendingMachine.Products.Count());
        }

        [Fact]
        public void TotalpriceTest()
        {
            vendingMachine.ByedList.Add(Chips);
            vendingMachine.ByedList.Add(Chips);

            Assert.True(vendingMachine.ByedList.Any());
            Assert.Equal(2, vendingMachine.ByedList.Count());
            Assert.Equal(40, vendingMachine.Totalprice());

        }
        [Fact]
        public void CheckMoneyTest()
        {
            vendingMachine.Money = 10;
            vendingMachine.ByedList.Add(Chips);
            vendingMachine.ByedList.Add(Chips);

            Assert.False(vendingMachine.CheckMoney());
            
            // vendingMachine.Money = 100;
            // Assert.True(vendingMachine.CheckMoney());
        }
        [Fact]
        public void InsertMoneyTest()
        {
            vendingMachine.Money = 50;
            vendingMachine.InsertMoney(100);
            Assert.Equal(150,vendingMachine.Money);
        }
        [Fact]
        public void EndTransactionTest()
        {
            vendingMachine.Money = 150;
            Dictionary<int,int> ReturnMoney = vendingMachine.EndTransaction();

            Assert.Equal(100, ReturnMoney[0]);
            Assert.Equal(50 , ReturnMoney[1]);

        }


    }
}
