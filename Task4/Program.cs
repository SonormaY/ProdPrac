// з використанням делегатів. 
//За допомогою цієї функції виконати п’ятикратне згладжування деякого масиву.
namespace Task4;
class Program
{
    delegate void SmoothArrayDelegate(ref int[] array, int k);

    static void Main()
    {
        Console.Clear();
        // Setups
        int[] array = new int[10];
        Random random = new Random();
        array = Enumerable.Range(1, array.Length)
            .Select(_ => random.Next(1, 10))
            .ToArray();
        Console.WriteLine("Initial array: " + string.Join(" ", array));

        // Input
        Console.Write("Enter i: ");
        int k = int.Parse(Console.ReadLine() ?? "1") - 1;

        // Delegate
        SmoothArrayDelegate smoothArray = SmoothArray;
        
        // Smooth array
        for (int i = 0; i < 5; i++)
        {
            smoothArray(ref array, k);
        }

        // Output
        Console.Write("Smoothed array: ");
        Console.WriteLine(string.Join(" ", array));
    }

    static void SmoothArray(ref int[] array, int k)
    {
        int[] copy = new int[array.Length];
        array.CopyTo(copy, 0);
        int avg = array.Select((x, i) => i <= k ? x : 0).Sum() / k;
        copy[k] = copy[k - 1] + avg / 2;
        array = copy;
    }
}