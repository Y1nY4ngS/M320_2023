namespace Repitition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 10;
            IncrementValue(ref val);
            Console.WriteLine(val);
            /* aufgabe 2
            int[] array = { 200, 450, 700, 175, 250 };
            int sum = array.Sum();

            Console.WriteLine(sum);
            */
        }
        public static void IncrementValue(ref int value)
        {
            value = value + 1;
        }
    }
}