using System.Security.Cryptography.X509Certificates;
using Tyuiu.FattahovAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.FattahovAA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(0, DataService.Addition(5, 5));
        }
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(25, DataService.Addition(5, 5));
        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(1, DataService.Addition(5, 5));
        }
    }
}