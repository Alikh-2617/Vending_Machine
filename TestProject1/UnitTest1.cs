using System.Diagnostics;
using Vending_Machine;

namespace TestProject1
{
    public class UnitTest1
    {
        Sandwich Sandwich = new Sandwich();
        [Fact]
        public void SandwichTest()
        {
            Assert.Equal("bara �t den , s� enkelt !", Sandwich.Description());
            Assert.Equal("Sm�rg�s", Sandwich.Name());
            Assert.Equal(25, Sandwich.Price());
        }

        Dricka Dricka = new Dricka();
        [Fact]
        public void DrickaTest()
        {
            Assert.Equal("Dick upp den om du �r inte klock !", Dricka.Description());
            Assert.Equal("Dicka f�r t�rstiga", Dricka.Name());
            Assert.Equal(10, Dricka.Price());
        }

        Chips Chips = new Chips();
        [Fact]
        public void ChipsTest()
        {
            Assert.Equal("�ppna paketet och �t den bara fan !", Chips.Description());
            Assert.Equal("Chips f�r chubby. " , Chips.Name());
            Assert.Equal(15, Chips.Price());
        }
    }
}