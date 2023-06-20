namespace SelfCSharp.Chap03
{
    internal class Increment
    {
        static void Main(string[] _)
        {
            var i = 3;
            var j = ++i;
            Console.WriteLine(i);
            Console.WriteLine(j);

            var m = 3;
            var n = m++;
            Console.WriteLine(m);
            Console.WriteLine(n);
        }
    }
}