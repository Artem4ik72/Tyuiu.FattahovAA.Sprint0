namespace Tyuiu.FattahovAA.Sprint0.Task5.V0.Test
{
    using Tyuiu.FattahovAA.Sprint0.Task5.V0.Lib;
    [TestClass]
    public class DataserviceTest
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
            Assert.AreEqual(3, DataService.Addition(9, 3));
        }
        public void CheckedDivisionValidIfZero()
        {
            Assert.AreEqual(-1, DataService.Addition(9, 0));
        }
    }
}