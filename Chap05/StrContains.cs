namespace SelfCSharp.Chap05
{
    internal class StrContains
    {
        static void Main(string[] args)
        {
            var str = "ＷＩＮＧＳプロジェクト";

            Console.WriteLine(str.Contains("プロ"));
            Console.WriteLine(str.StartsWith("ＷＩＮＧＳ"));
            Console.WriteLine(str.EndsWith("ＷＩＮＧＳ"));
        }
    }
}