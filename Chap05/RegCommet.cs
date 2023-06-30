using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegComment
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            var result = @"(\d{2,4}) #市外局番
            -(\d{2,4}) #市内局番
            -(\d{4}) #加入番号";
            var reg = new Regex(result, RegexOptions.IgnorePatternWhitespace);
            var match = reg.Match(str);

            if (match.Success)
            {
                Console.WriteLine($"位置:{match.Index} マッチ文字列:{match.Value}");
                foreach (Group m in match.Groups)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }
}