using Tyuiu.ShurlyginDS.Sprint1.Task2.V2.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 57;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(0.995, res);
        }
    }
}
