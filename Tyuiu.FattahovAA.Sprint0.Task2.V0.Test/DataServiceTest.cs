using System.Security.Cryptography.X509Certificates;
using Tyuiu.FattahovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.FattahovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassegeValid()
        {
            var name = "»√Œ–‹";
            var res = DataService.GetMessege(name);

            Assert.AreEqual("œË‚ÂÚ, »√Œ–‹", res);
        }
    }
}