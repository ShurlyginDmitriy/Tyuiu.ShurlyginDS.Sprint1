using Tyuiu.ShurlyginDS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            double temp = 50;

            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(temp);

            int result = Convert.ToInt32(res);

            int wait = 10;

            Assert.AreEqual(wait, result);
        }
    }
}
