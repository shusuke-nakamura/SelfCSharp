namespace SelfCSharp.Chap02.Practice
{
    internal class Practice3
    {
        static void Main(string[] _)
        {
            const Double Discount = 0.9;
            int price = 500;
            double sum = price * Discount;
            Console.WriteLine($"値引き後の価格は{sum}円です。");
        }
    }
}