using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegSingle
    {
        static void Main(string[] args)
        {
            var str = "初めまして。\nよろしくお願いします";
            var reg = new Regex(@"^.+", RegexOptions.Singleline);
            var result = reg.Matches(str);

            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}