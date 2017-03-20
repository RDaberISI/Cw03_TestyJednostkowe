using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;

//chujowe, do poprawy
namespace DivideNumbersTests
{
    [TestFixture]
    public class DivideNumbersTests
    {
        [Test]
        public void Podziel_DivideTwoPositiveNumbers_Calculated()
        {
            var calc = new DivideNumbers.DivideNumbers();            
            double iloraz = calc.Podziel(2, 2);
            Assert.AreEqual(1, iloraz);
        }
        
        [Test]
        public void Podziel_OneNegativeAndOnePositiveNumbers_Calculated()
        {
            var calc = new DivideNumbers.DivideNumbers();
            double iloraz = calc.Podziel(-2, 2);
            Assert.AreEqual(-1, iloraz);
        }

        [Test]
        public void Podziel_OnePositiveAndOneNegativeNumbers_Calculated()
        {
            var calc = new DivideNumbers.DivideNumbers();
            double iloraz = calc.Podziel(2, -2);
            Assert.AreEqual(-1, iloraz);
        }

        [Test]
        public void Podziel_DivideTwoNegativeNumbers_Calculated()
        {
            var calc = new DivideNumbers.DivideNumbers();
            double iloraz = calc.Podziel(-2, -2);
            Assert.AreEqual(1, iloraz);
        }
    }
}
