namespace SelfCSharp.Chap03
{
    internal class ConditionNull
    {
        static void Main(string[] _)
        {
            string? str = "山田";
            string def = "権兵衛";
            Console.WriteLine(str ?? def);
        }
    }
}