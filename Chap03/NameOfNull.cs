namespace SelfCSharp.Chap03
{
    internal class NameOfNull
    {
        public void Hoge(string? str)
        {
            if (str == null)
            {
                // throw new ArgumentNullException(nameof(str));
                throw new ArgumentNullException("str");
            }
            Console.WriteLine(str);
        }

        static void Main(string[] _)
        {
            var nc = new NameOfNull();
            nc.Hoge(null);
        }
    }
}