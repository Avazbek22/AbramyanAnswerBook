using System.Globalization;

namespace AbramyanAnswerBook;

public class Strings
{
    static void String7()
    {
        Console.Write("Enter text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine($"First code: {(int) str.First()}");
        Console.WriteLine($"Last code: {(int) str.Last()}");
    }

    static void String8()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter C: ");
        char symbol = char.Parse(Console.ReadLine()!);
        Console.WriteLine($"Result: {new string(symbol, n)}");
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

    static void String11()
    {
        Console.Write("Enter text: ");
        string str = Console.ReadLine()!;
        foreach (var t in str)
            Console.Write(t + " ");
    }

    static void String13()
    {
        Console.Write("Enter text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine($"Result: {str.Count(char.IsDigit)}");
    }

    static void String14()
    {
        Console.Write("Enter a text: ");
        Console.WriteLine($"Count of upper letters: {Console.ReadLine()!.Count(char.IsUpper)}");
        
        if (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out _))
            Console.WriteLine("It's a float number");
    }

    static void String15()
    {
        //String 15. Дана строка. Подсчитать общее количество содержащихся в ней строчных латинских и русских букв.
        Console.Write("Enter any text: ");
        Console.WriteLine(Console.ReadLine()!.Count(char.IsLower));
    }

    static void String16()
    {
        //String 16. Дана строка. Преобразовать в ней все прописные латинские буквы в строчные
        Console.Write("Enter any text: ");
        string text = Console.ReadLine()!;
        
        // string result = Regex.Replace(text, "[^A-Z]", "").ToLower();
        // string result = new string(text.Where(c => Regex.IsMatch(c.ToString(), "[A-Z]")).Select(char.ToLower).ToArray());
        
        string result = new string(text.Where(c => c >= 'A' && c <= 'Z').Select(char.ToLower).ToArray());
        Console.WriteLine(result);
    }

    static void String17()
    {
        //String 17. Дана строка. Преобразовать в ней все строчные буквы(как латинские, так и русские) в прописные.
        Console.Write("Enter any text: ");
        string text = Console.ReadLine()!;
        
        // string result = text.ToUpper();
        
        string result = new string(text.Select(char.ToUpper).ToArray());

        Console.WriteLine(result);
    }

    static void String18()
    {
        //String 18. Дана строка. Преобразовать в ней все строчные буквы (как латинские, так и русские) в прописные, а прописные — в строчные.
        Console.Write("Enter any text: ");
        string text = Console.ReadLine()!;
        string result = new string(text.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
        Console.WriteLine(result);
    }

    static void String19()
    {
        //String 19. Дана строка. Если она представляет собой запись целого числа, то вывести 1, если вещественного (с дробной частью) — вывести 2;
        //если строку нельзя преобразовать в число, то вывести 0.
        //Считать, что дробная часть вещественного числа отделяется от его целой части десятичной точкой «.».
        Console.Write("Enter any number: ");
        string str = Console.ReadLine()!.Replace('.', ',');
        if (int.TryParse(str, out _))
            Console.WriteLine(1);
        else if (float.TryParse(str, out _))
            Console.WriteLine(2);
        else
            Console.WriteLine(0);
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

    static void String20()
    {
        //String20.Дано целое положительное число. Вывести символы, изображающие цифры этого числа(в порядке слева направо).
        Console.Write("Enter any number: ");
        string number = Console.ReadLine()!;
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write($"{number[i]} ");
        }
    }

    static void String21()
    {
        //String21.Дано целое положительное число. Вывести символы, изображающие цифры этого числа(в порядке справа налево).
        Console.Write("Enter any number: ");
        int number = int.Parse(Console.ReadLine());
        string numberText = number.ToString();
        for (int i = numberText.Length - 1; i >= 0; i--)
        {
            Console.Write($"{numberText[i]} ");
        }
    }

    static void String22()
    {
        // String22. Дана строка, изображающая целое положительное число. Вывести сумму цифр этого числа.

        Console.Write("Enter a text: ");
        // Console.WriteLine($"Sum: {Console.ReadLine()!.Select(n => int.Parse(n.ToString())).Sum()}"); // #1
        Console.WriteLine($"Sum: {Console.ReadLine()!.Select(char.GetNumericValue).Sum()}"); // #2
    }

    static void String44()
    {
        Console.Write("Enter a text: ");
        string s = Console.ReadLine()!;
        var count = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(c => c.Count(ch => ch == 'A') == 3);
        Console.WriteLine($"Count: {count}");
    }

    static void String45()
    {
        Console.Write("Enter a text: ");
        string s = Console.ReadLine()!;
        var minLength = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Min(c => c.Length);
        Console.WriteLine($"Min length: {minLength}");
    }

    static void String48()
    {
        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        var words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = new string(words[i]
                .Select((c, index) => index == 0 ? c : (c == words[i][0] ? '.' : c))
                .ToArray());
        }

        int d = 1;
        Console.WriteLine(d * 3.14);

        Console.WriteLine($"Result: {string.Join(' ', words)}");
    }
    
    static void String57_2()
    {
        // String57. Дана строка-предложение с избыточными пробелами между слова
        // ми. Преобразовать ее так, чтобы между словами был ровно один пробел.
        string s = Console.ReadLine()!;
        // Это разбивает по любым пробельным символам (пробел, табуляция, перевод строки и т.д.).
        // Фишка в том, что null в Split((char[])null, ...) означает использовать все стандартные пробельные символы.
        string t = String.Join(" ", s.Split((char[])null!, StringSplitOptions.RemoveEmptyEntries)); 
        Console.WriteLine(t);
    }


    static void String58()
    {
        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        string fileName = new string(str.Split('\\').Last().TakeWhile(c => c != '.').ToArray());
        Console.WriteLine(fileName);
    }
    
    static void String58_3()
    {
        string s = Console.ReadLine()!;
        // Получаем имя файла без расширения
        string fileName = Path.GetFileNameWithoutExtension(s);
        Console.WriteLine(fileName);
    }
    
    public static void Main()
    {
        // Изучить StringBuilder
        String22();
    }

}