using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;

namespace KontoBankowe.Tests
{
    [TestFixture]
    public class KontoBankowe
    {
        [Test]
        public void WplacPieniadze_DepositeMoney_Calculated()
        {
            var konto1 = new Bank.KontoBankowe(200);
            konto1.WplacPieniadze(100);
            Assert.AreEqual(300, konto1.SprawdzStanKonta);
        }

        [Test]
        public void WyplacPieniadze_WithdrawMoney_Calculated()
        {
            var konto1 = new Bank.KontoBankowe(200);
            konto1.WyplacPieniadze(100);
            Assert.AreEqual(100, konto1.SprawdzStanKonta);
        }

        [Test]
        public void WyplacPieniadze_WithdrawMoneyWithInsufficientFunds()
        {
            var konto1 = new Bank.KontoBankowe(200);

            try
            {
                konto1.WyplacPieniadze(300);
            }
            catch(Bank.WyjatekNiewystarczajaceSrodkiNaKoncie expected)
            {
            }
            Assert.AreEqual(200, konto1.SprawdzStanKonta);
        }

        [Test]
        public void TransferPieniedzy_TransferFoundsPositive_Calculated()
        {
            var konto1 = new Bank.KontoBankowe(300);
            var konto2 = new Bank.KontoBankowe(500);

            konto1.PrzelejKwoteNaInneKonto(konto2, 200);

            Assert.AreEqual(100, konto1.SprawdzStanKonta);
            Assert.AreEqual(700, konto2.SprawdzStanKonta);
        }

        [Test]
        public void TransferPieniedzy_TransferFoundsWithInsufficentFounds_Calculated()
        {
            var konto1 = new Bank.KontoBankowe(300);
            var konto2 = new Bank.KontoBankowe(500);

            try
            {
                konto1.PrzelejKwoteNaInneKonto(konto2, 200);
            }
            catch(Bank.WyjatekNiewystarczajaceSrodkiNaKoncie expected)
            {
            } 

            Assert.AreEqual(100, konto1.SprawdzStanKonta);
            Assert.AreEqual(700, konto2.SprawdzStanKonta);
        }
    }
}
