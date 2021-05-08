using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using MethodLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class MaxAndMeanTests
    {
        [TestMethod]
        public void MaxAndMeanTest1()
        {
            Class1 cls = new Class1();
            double Mean = 0.0;

            int Exp_Max = 6;
            double Exp_Mean = 4;

            int max = cls.MaxAndMean(4, 6, 2, out Mean);

            Assert.AreEqual(Exp_Max, max, 0.1);
            Assert.AreEqual(Exp_Mean, Mean, 0.1);
        }

        [TestMethod]
        public void MaxAndMeanTest2()
        {
            Class1 cls = new Class1();
            double Mean = 0.0;

            int Exp_Max = 6;
            double Exp_Mean = 4;

            int max = cls.MaxAndMean(4, 6, 2, out Mean);

            Assert.AreEqual(Exp_Max, max, 0.1);
            Assert.AreEqual(Exp_Mean, Mean, 0.1);
        }
    }
}
