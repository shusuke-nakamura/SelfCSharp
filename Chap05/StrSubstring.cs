namespace SelfCSharp.Chap05
{
    internal class StrSubstring
    {
        static void Main(string[] args)
        {
            var str = "ＷＩＮＧＳプロジェクト";
            Console.WriteLine(str.Substring(5, 2));

            var path = @"C:\data\wings.jpg";
            Console.WriteLine(path.Substring(path.LastIndexOf(".") + 1));
        }
    }
}