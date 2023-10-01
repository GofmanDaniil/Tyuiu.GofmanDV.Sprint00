using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint0.Task2.Lib;
namespace Tyuiu.GofmanDV.Sprint0.Task2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            
            var name = "Даниил";
            var res = DataService.GetMessage(name);

            
            Assert.AreEqual("Привет, Даниил", res);
        }
    }
}
