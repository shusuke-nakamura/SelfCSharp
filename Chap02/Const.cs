namespace SelfCSharp.Chap02
{
    internal class Const
    {
        static void Main(string[] _)
        {
            const double Tax = 1.1;
            int price = 1000;
            double sum = price * Tax;
            Console.WriteLine(sum);
        }
    }
}