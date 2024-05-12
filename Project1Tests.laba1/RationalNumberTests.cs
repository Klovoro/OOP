using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Tests
{
    [TestClass()]
    public class RationalNumberTests
    {
        [TestMethod()]
        public void Summ()
        {
            RationalNumber r1 = new RationalNumber(3, 4);
            RationalNumber r2 = new RationalNumber(2, 4);
            RationalNumber r3 = new RationalNumber(5, 4);

            RationalNumber res = r1 + r2;
            Assert.IsTrue(res == r3);
        }
        [TestMethod()]
        public void Equal()
        {
            RationalNumber r1 = new RationalNumber(3, 4);
            RationalNumber r2 = new RationalNumber(3, 4);
            Assert.IsTrue(r1 == r2);
        }
    }
}