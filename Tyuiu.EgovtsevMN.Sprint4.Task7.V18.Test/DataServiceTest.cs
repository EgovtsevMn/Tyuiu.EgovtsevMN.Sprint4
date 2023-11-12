using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint4.Task7.V18.Lib;

namespace Tyuiu.EgovtsevMN.Sprint4.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "145258749635789";
            int res = ds.Calculate(rows, columns, str);
            int wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}
