using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел");
        int count = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вводите числа");
        List<int> numbers = new List<int>();
        for(int i = 0; i<count; i++)
        {
            Console.WriteLine($"Число {i+1}");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();
        }
        int negativeCount = numbers.Count(n => n < 0);
        int positiveSum = numbers.Where(n => n > 0).Sum();
        int evenProduct = numbers.Where(n => n % 2 == 0).Aggregate(1, (acc, n) => acc * n);
        Console.WriteLine($"Negative count: {negativeCount}");
        Console.WriteLine($"Positive sum: {positiveSum}");
        Console.WriteLine($"Even product: {evenProduct}");
    }
}
