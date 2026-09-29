using Tyuiu.ShurlyginDS.Sprint1.Task7.V13.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 5;
            double z = 1.678;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
