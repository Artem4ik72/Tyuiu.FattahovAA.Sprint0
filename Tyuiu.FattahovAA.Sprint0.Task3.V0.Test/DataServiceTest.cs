namespace Tyuiu.FattahovAA.Sprint0.Task3.V0.Test
{
    using Tyuiu.FattahovAA.Sprint0.Task3.V0.Lib;
    [TestClass]
    public class DataServiceTest
    {
        
        [TestMethod]
        public void CheckedValid()
        {
            DataService DD = new DataService();
            int res = DD.Sum(5, 2);

            Assert.AreEqual(7, res);
        }
    }
}