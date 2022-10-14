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
            Assert.Equal("bara ät den , så enkelt !", Sandwich.Description());
            Assert.Equal("Smörgås", Sandwich.Name());
            Assert.Equal(25, Sandwich.Price());
        }

        Dricka Dricka = new Dricka();
        [Fact]
        public void DrickaTest()
        {
            Assert.Equal("Dick upp den om du är inte klock !", Dricka.Description());
            Assert.Equal("Dicka för törstiga", Dricka.Name());
            Assert.Equal(10, Dricka.Price());
        }

        Chips Chips = new Chips();
        [Fact]
        public void ChipsTest()
        {
            Assert.Equal("Öppna paketet och ät den bara fan !", Chips.Description());
            Assert.Equal("Chips för chubby. " , Chips.Name());
            Assert.Equal(15, Chips.Price());
        }
    }
}