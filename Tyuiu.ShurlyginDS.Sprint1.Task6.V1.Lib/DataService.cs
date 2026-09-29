using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShurlyginDS.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            char ch = Convert.ToChar(value);

            int code = Convert.ToInt32(ch);

            return code.ToString();
        }
    }
}
