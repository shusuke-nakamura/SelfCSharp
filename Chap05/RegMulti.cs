using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegMulti
    {
        static void Main(string[] args)
        {
            var str = "10人のインディアン。\n1年生になったら";
            var reg = new Regex(@"^\d+", RegexOptions.Multiline);
            var result = reg.Matches(str);

            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}