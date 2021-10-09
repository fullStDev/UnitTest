using Microsoft.VisualStudio.TestTools.UnitTesting;
using ErmakovISP_31ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErmakovISP_31ClassLib.Tests
{
    [TestClass()]
    public class ErmakovISP_31ClassTests
    {
        [TestMethod()]
        public void SumTest()
        {
            int x = 10;
            int y = 5;
            int expected = 15;

            ErmakovISP_31Class Er = new ErmakovISP_31Class();
            int actual = Er.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}