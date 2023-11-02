internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 4, 7, 10 };
        int product = numbers.Aggregate(1, (int interim, int next) => interim * next);
        Console.WriteLine(product);   // output: 280
    }
}