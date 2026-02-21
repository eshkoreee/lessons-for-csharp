namespace lesson85
{
    internal class Program
    {
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield break;
            yield return 3;
        }
        static void Main(string[] args)
        {
            IEnumerable<int> sequence = new NumberSequence(start: 10, count: 3);         

            var enumerator = sequence.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
