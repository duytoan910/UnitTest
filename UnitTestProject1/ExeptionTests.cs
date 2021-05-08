using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ExeptionTests
    {
        [ExpectedException(typeof(Exception))]
        public void GetTotalItemPriceTest()
        {
            Class1 target = new Class1();
            int count = -1;
            double expected = 0F;
            double actual;
            actual = target.GetTotalItemPrice(count);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ExeptionTest_1()
        {
            Exception expectedException = null;
            try
            {
                GetTotalItemPriceTest();
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
        [TestMethod()]
        public void ExeptionTest_2()
        {
            try
            {
                GetTotalItemPriceTest();
                Assert.Fail(); // raises AssertionException
            }
            catch (FormatException)
            {
                // Catches the assertion exception, and the test passes
            }
            catch (Exception)
            {
                // Catches the assertion exception, and the test passes
            }
        }
    }
}
