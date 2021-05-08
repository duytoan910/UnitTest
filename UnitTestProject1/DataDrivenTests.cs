using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DataDrivenTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\tests.csv", "tests#csv", DataAccessMethod.Sequential), DeploymentItem("tests.csv"), TestMethod]

        public void TienDienDriven()
        {
            MethodLibrary.MethodLibrary cls = new MethodLibrary.MethodLibrary();

            int chiSoCu = Convert.ToInt32(TestContext.DataRow[1].ToString());
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow[2].ToString());
            double actual = cls.TinhTienDien(chiSoCu, chiSoMoi);
            double expected = Convert.ToDouble(TestContext.DataRow[3].ToString());

            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}
