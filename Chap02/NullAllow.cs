namespace SelfCSharp.Chap02
{
    internal class NullAllow
    {
        static void Main(string[] _)
        {
            // string str = null;
            string? str = null;
            Console.WriteLine(str);
        }
    }
}