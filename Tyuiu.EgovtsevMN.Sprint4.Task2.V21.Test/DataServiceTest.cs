using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint4.Task2.V21.Lib;

namespace Tyuiu.EgovtsevMN.Sprint4.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4 };
            Assert.AreEqual(8, ds.Calculate(array));
        }
    }
}
