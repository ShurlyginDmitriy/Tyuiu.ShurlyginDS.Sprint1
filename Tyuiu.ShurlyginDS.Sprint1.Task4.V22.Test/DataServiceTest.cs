using Tyuiu.ShurlyginDS.Sprint1.Task4.V22.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 9;
            double wait = 0.008;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
