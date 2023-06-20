namespace SelfCSharp.Chap03
{
    internal class CompareString
    {
        static void Main(string[] _)
        {
            string data = "123";
            int data2 = 123;
            Console.WriteLine(data.Equals(data2));
            // Console.WriteLine(data == data2);
        }
    }
}