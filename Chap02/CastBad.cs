namespace SelfCSharp.Chap02
{
    internal class CastBad
    {
        static void Main(string[] _)
        {
            int i = 128;
            sbyte b = (sbyte)i;
            Console.WriteLine(b);
        }
    }
}