using System.Globalization;

namespace AbramyanAnswerBook;

public class Strings
{
    public static void Main()
    {
        // Изучить StringBuilder
        String44();
    }
    
    static void String7()
    {
        Console.Write("Enter text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine($"First code: {(int) str.First()}");
        Console.WriteLine($"Last code: {(int) str.Last()}");
    }

    static void String9()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter C1: ");
        char c1 = char.Parse(Console.ReadLine()!);
        Console.Write("Enter C2: ");
        char c2 = char.Parse(Console.ReadLine()!);
        for (int i = 0; i < n / 2; i++)
            Console.Write($"{c1}{c2}");

        string s = "HEllo";
        Console.WriteLine();
    }

    static void String14()
    {
        Console.Write("Enter a text: ");
        Console.WriteLine($"Count of upper letters: {Console.ReadLine()!.Count(char.IsUpper)}");
        
        if (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out _))
            Console.WriteLine("It's a float number");
    }

    static void String22()
    {
        Console.Write("Enter a text: ");
        Console.WriteLine($"Sum: {Console.ReadLine()!.Select(Convert.ToInt32).Sum()}");
    }

    static void String44()
    {
        Console.Write("Enter a text: ");
        string s = Console.ReadLine()!;
        var count = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(c => c.Count(ch => ch == 'A') == 3);
        Console.WriteLine($"Count: {count}");
    }
}