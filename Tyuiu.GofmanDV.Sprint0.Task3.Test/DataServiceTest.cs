using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint0.Lib;
namespace Tyuiu.GofmanDV.Sprint0.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(14, DataService.Sum(7, 7));
        }
    }
}
