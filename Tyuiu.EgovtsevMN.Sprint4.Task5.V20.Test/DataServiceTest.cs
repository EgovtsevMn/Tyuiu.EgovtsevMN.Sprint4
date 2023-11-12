using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint4.Task5.V20.Lib;

namespace Tyuiu.EgovtsevMN.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {{-6, -5,- 6, 3, 1 },
                                        { -5, -4, -6, 1, 3 },
                                        { -5, -5, 2, -7, 2 },
                                        { -6, 2, -4, -4, 1 },
                                        { -4, 3, -4, -5, 1} };
            int res = ds.Calculate(matrix);
            int wait = 19;
            Assert.AreEqual(wait, res);
        }
    }
}
