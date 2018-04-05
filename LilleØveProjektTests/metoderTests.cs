using Microsoft.VisualStudio.TestTools.UnitTesting;
using LilleØveProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilleØveProjekt.Tests
{
    [TestClass()]
    public class metoderTests
    {
        metoder testMetoder = new metoder();

        [TestMethod()]
        public void additionTest()
        {
            int resultat = testMetoder.addition(2, 2);

            Assert.AreEqual(4, resultat);
        }

        [TestMethod()]
        public void subtractionTest()
        {
            int resultat = testMetoder.subtraction(3, 2);

            Assert.AreEqual(1,resultat);
        }

        [TestMethod()]
        public void multiplicationTest()
        {
            int resultat = testMetoder.multiplication(2, 2);

            Assert.AreEqual(5,resultat);
        }
    }
}