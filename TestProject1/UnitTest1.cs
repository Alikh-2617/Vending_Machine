using System.Diagnostics;
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
        public List<Product> ByedList = new List<Product>();

        //[Fact]
        //public void vendingMachineTest()
        //{
        //    vendingMachine.Money = 0;
        //    vendingMachine.Products.Add(Dricka);

        //    Assert.Equal();
        //}



        [Fact]
        public void TotalpriceTest()
        {
            vendingMachine.Money = 15;
            Assert.Equal(0, vendingMachine.Totalprice());
        }

        [Fact]
        public void CheckMoneyTest()
        {
            List<Product> Products = new List<Product>();
            Products.Add(new Dricka(15, "ii", "ww"));
            vendingMachine.Money = 20;

            Assert.True(Products.Any());
            Assert.Equal(1, Products.Count());

        }
       
    }
}