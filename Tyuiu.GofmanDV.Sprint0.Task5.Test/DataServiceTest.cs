using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint0.Task5.Lib;
namespace Tyuiu.GofmanDV.Sprint0.Task5.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(4, DataService.Addition(2, 2));
        }

        
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(20, DataService.Multiplication(2, 10));
        }

        
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }

}
