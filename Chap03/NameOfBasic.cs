namespace SelfCSharp.Chap03
{
    internal class NameOfBasic
    {
        int data = 1;
        static void Main(string[] _)
        {
            Console.WriteLine(nameof(NameOfBasic));
            Console.WriteLine(nameof(data));
        }
    }
}