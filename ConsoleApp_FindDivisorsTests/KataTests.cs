using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_FindDivisors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_FindDivisors.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void DivisorsTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Kata.Divisors(15));
        }
    }
}