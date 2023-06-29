using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegIgnore
    {
        static void Main(string[] args)
        {
            var str = "仕事用はwings@example.comです。プライベート用はYAMA@example.comです。";
            var reg = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);
            var result = reg.Matches(str);

            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}