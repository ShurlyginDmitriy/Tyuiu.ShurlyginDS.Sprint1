using Tyuiu.ShurlyginDS.Sprint1.Task6.V1.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "1";
            DataService ds = new DataService();

            string res = ds.SymbolCode(strTest);
            string wait = "49";

            Assert.AreEqual(wait, res);
        }
    }
}
