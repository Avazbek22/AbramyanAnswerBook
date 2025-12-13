using System.Globalization;
using System.Text.RegularExpressions;

namespace AbramyanAnswerBook;

public class Strings
{
    static void String1()
    {
        // String1. Дан символ C. Вывести его код (то есть номер в кодовой таблице).

        Console.Write("Enter C: ");
        char c = char.Parse(Console.ReadLine()!);
        Console.WriteLine((int)c); // Unicode
    }

    static void String2()
    {
        // String 2. Дано целое число N (32 ≤ N ≤ 126). Вывести символ с кодом, равным N.
        
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine((char)n);
    }

    static void String3()
    {
       // String 3. Дан символ C. Вывести два символа,
       // первый из которых предшествует символу C в кодовой таблице, а второй следует за символом C.
       
       Console.Write("Enter C: ");
       char c = char.Parse(Console.ReadLine()!);
       Console.WriteLine($"Previous: {(char)(c - 1)}");
       Console.WriteLine($"Next: {(char)(c + 1)}");
    }

    static void String4()
    {
        // String 4. Дано целое число N (1 ≤ N ≤ 26).
        // Вывести N первых прописных (то есть заглавных) букв латинского алфавита.
        
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
            Console.Write((char)('A' + i));
    }

    static void String5()
    {
        // String 5. Дано целое число N (1 ≤ N ≤ 26). Вывести N последних строчных
        // (то есть маленьких) букв латинского алфавита в обратном порядке (начиная с буквы «z»).

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
            Console.Write((char)('z' - i));
    }

    static void String6()
    {
        // String 6. Дан символ C, изображающий цифру или букву (латинскую или русскую).
        // Если C изображает цифру, то вывести строку «digit»,
        // если латинскую букву — вывести строку «lat», если русскую — вывести строку «rus».

        Console.Write("Enter C: ");
        char c = char.Parse(Console.ReadLine()!);
        c = char.ToLower(c);
        if (char.IsDigit(c))
            Console.WriteLine("digit");
        else if (c >= 'a' && c <= 'z')
            Console.WriteLine("lat");
        else if ((c >= 'а' && c <= 'я') || c == 'ё')
            Console.WriteLine("rus");
    }
    
    static void String7()
    {
        // String 7. Дана непустая строка. Вывести коды ее первого и последнего символа.
        
        Console.Write("Enter text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine($"First code: {(int)str.First()}");
        Console.WriteLine($"Last code: {(int)str.Last()}");
    }

    static void String8()
    {
        // String 8. Дано целое число N (> 0) и символ C. Вывести строку длины N, которая состоит из символов C.
        
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter C: ");
        char symbol = char.Parse(Console.ReadLine()!);
        Console.WriteLine($"Result: {new string(symbol, n)}");
    }

    static void String9()
    {
        // String 9. Дано четное число N (> 0) и символы C1 и C2.
        // Вывести строку длины N, которая состоит из чередующихся символов C1 и C2, начиная с C1.

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter C1: ");
        char c1 = char.Parse(Console.ReadLine()!);
        Console.Write("Enter C2: ");
        char c2 = char.Parse(Console.ReadLine()!);
        for (int i = 0; i < n / 2; i++)
            Console.Write($"{c1}{c2}");
        
    }

    static void String10()
    {
        // String 10. Дана строка. Вывести строку, содержащую те же символы, но расположенные в обратном порядке.
        
        Console.Write("Enter text: ");
        string text = Console.ReadLine()!;
        Console.WriteLine($"Обратная строка: {new string(text.Reverse().ToArray())}");
    }

    static void String11()
    {
        // String 11. Дана непустая строка S. Вывести строку, содержащую символы строки S, между которыми вставлено по одному пробелу.
        
        Console.Write("Enter text: ");
        string str = Console.ReadLine()!;
        foreach (var t in str)
            Console.Write(t + " ");

        // Console.WriteLine(string.Join(" ", str)); // #2
        // Console.WriteLine(string.Join(" ", str.ToCharArray())); // #3 without space at end
    }

    static void String12()
    {
        // String 12. Дана непустая строка S и целое число N (> 0). Вывести строку, содержащую символы строки S,
        // между которыми вставлено по N символов «*» (звездочка).

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine(string.Join(new string('*', n), s.ToCharArray())); // Without ToCharArray doesn't work 
    }

    static void String13()
    {
        // String 13. Дана строка. Подсчитать количество содержащихся в ней цифр.
        
        Console.Write("Enter text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine($"Result: {str.Count(char.IsDigit)}");
    }

    static void String14()
    {
        // String 14. Дана строка. Подсчитать количество содержащихся в ней прописных латинских букв.
        
        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(str.Count(c => c >= 'A' && c <= 'Z')); 

        // Console.WriteLine($"Count of upper letters: {str.Count(char.IsUpper)}"); // #2 Считает буквы всех алфавитов
    }

    static void String15()
    {
        //String 15. Дана строка. Подсчитать общее количество содержащихся в ней строчных латинских и русских букв.
        
        Console.Write("Enter any text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(str.Count(c => (c >= 'a' && c <= 'z') || (c >= 'а' && c <= 'я') || c == 'ё'));
        
        // Console.WriteLine(str.Count(char.IsLower)); // #2 Считает также символы других языков
    }

    static void String16()
    {
        // String 16. Дана строка. Преобразовать в ней все прописные латинские буквы в строчные
        
        Console.Write("Enter any text: ");
        string text = Console.ReadLine()!;

        string result = new string(text.Select(c => (c >= 'A' && c <= 'Z') ? char.ToLower(c) : c).ToArray());
        // string result = Regex.Replace(text, "[A-Z]", m => m.Value.ToLower()); // Regex variant

        Console.WriteLine(result);
    }


    static void String17()
    {
        //String 17. Дана строка. Преобразовать в ней все строчные буквы(как латинские, так и русские) в прописные.
        
        Console.Write("Enter any text: ");
        string text = Console.ReadLine()!;
        Console.WriteLine(text.ToUpper());
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
        string str = Console.ReadLine()!;
        if (int.TryParse(str, out _))
            Console.WriteLine(1);
        else if (double.TryParse(str, out _) && str.Contains('.'))
            Console.WriteLine(2);
        else
            Console.WriteLine(0);
    }

    static void String19_2()
    {
        Console.Write("Enter any number: ");
        string str = Console.ReadLine()!;
        
        if (int.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out _))
            Console.WriteLine(1);
        else if (double.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out _) && str.Contains('.'))
            Console.WriteLine(2);
        else
            Console.WriteLine(0);
    }

    static void String20()
    {
        //String20. Дано целое положительное число. Вывести символы, изображающие цифры этого числа(в порядке слева направо).
        Console.Write("Enter any number: ");
        string number = Console.ReadLine()!;
        for (int i = 0; i < number.Length; i++)
            Console.Write($"{number[i]} ");
        
        // Console.WriteLine(string.Join(" ", number)); // #2
    }

    static void String21()
    {
        //String 21. Дано целое положительное число. Вывести символы, изображающие цифры этого числа(в порядке справа налево).
        Console.Write("Enter any number: ");
        string number = Console.ReadLine()!;
        for (int i = number.Length - 1; i >= 0; i--)
            Console.Write($"{number[i]} ");

        // Console.WriteLine(string.Join(" ", number.Reverse())); // #2
    }

    static void String22()
    {
        // String 22. Дана строка, изображающая целое положительное число. Вывести сумму цифр этого числа.

        Console.Write("Enter a number: ");
        string number = Console.ReadLine()!;
        
        Console.WriteLine($"Sum: {number.Select(char.GetNumericValue).Sum()}"); // #1
        // Console.WriteLine($"Sum: {number.Select(n => int.Parse(n.ToString())).Sum()}"); // #2
    }

    static void String23_Idk()
    {
        // String 23. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±. . .±<цифра>»,
        // где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»).
        // Вывести значение данного выражения (целое число).
        
        Console.Write("Enter expression: ");
        string s = Console.ReadLine()!;

        int result = s // Idk how it works! ¯\_(ツ)_/¯
            .Replace("-", "+-")
            .Split('+', StringSplitOptions.RemoveEmptyEntries)
            .Sum(int.Parse);

        Console.WriteLine(result);
    }
    
    static void String24()
    {
        // String 24. Дана строка, изображающая двоичную запись целого положительного числа.
        // Вывести строку, изображающую десятичную запись этого же числа.

        Console.Write("Enter binary number: ");
        string bin = Console.ReadLine()!;

        Console.WriteLine(Convert.ToInt32(bin, 2));
    }

    static void String25()
    {
        // String 25. Дана строка, изображающая десятичную запись целого положительного числа.
        // Вывести строку, изображающую двоичную запись этого же числа.
        
        Console.Write("Enter decimal number: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine(Convert.ToString(n, 2));
    }

    static void String26()
    {
        // String 26. Дано целое число N (> 0) и строка S. Преобразовать строку S в строку длины N следующим образом:
        // если длина строки S больше N, то отбросить первые символы, если длина строки S меньше N,
        // то в ее начало добавить символы «.» (точка).

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;

        if (s.Length > n)
        {
            s = s.Substring(s.Length - n);
        }
        else if (s.Length < n)
        {
            s = new string('.', n - s.Length) + s;
        }

        Console.WriteLine(s);
    }

    static void String26_Linq()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;

        string result = s.Length > n
            ? new string(s.Skip(s.Length - n).ToArray())
            : new string(Enumerable.Repeat('.', n - s.Length).Concat(s).ToArray());

        Console.WriteLine(result);
    }

    static void String27()
    {
        // String 27. Даны целые положительные числа N1 и N2 и строки S1 и S2.
        // Получить из этих строк новую строку, содержащую первые N1 символов
        // строки S1 и последние N2 символов строки S2 (в указанном порядке).

        Console.Write("Enter S1: ");
        string s1 = Console.ReadLine()!;
        Console.Write("Enter S2: ");
        string s2 = Console.ReadLine()!;
        Console.Write("Enter N1: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter N2: ");
        int n2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine(string.Concat(s1.Take(n1)) + string.Concat(s2.TakeLast(n2))); // ✓
        // Console.WriteLine(new string(s1.Take(n1).ToArray()) + new string(s2.TakeLast(n2).ToArray())); // X 
        
    }

    static void String32_Regex()
    {
        // String 32. Даны строки S и S0. Найти количество вхождений строки S0 в строку S.

        Console.Write("Enter S: ");
        string s = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter S0: ");
        string s0 = Console.ReadLine() ?? string.Empty;

        if (s0.Length == 0)
        {
            Console.WriteLine("Occurrences (overlapping): 0");
            Console.WriteLine("Occurrences (non-overlapping): 0");
            return;
        }

        // непересекающиеся: обычные совпадения
        string patternNonOverlapping = Regex.Escape(s0);
        int countNonOverlapping = Regex.Matches(s, patternNonOverlapping).Count;

        // пересекающиеся: позитивный просмотр вперёд
        string patternOverlapping = $"(?={Regex.Escape(s0)})";
        int countOverlapping = Regex.Matches(s, patternOverlapping).Count;

        Console.WriteLine($"Occurrences (overlapping): {countOverlapping}");
        Console.WriteLine($"Occurrences (non-overlapping): {countNonOverlapping}");
    }

    static void String39()
    {
        // String39. Дана строка, содержащая по крайней мере один символ пробела.
        // Вывести подстроку, расположенную между первым и вторым пробелом исходной строки.
        // Если строка содержит только один пробел, то вывести пустую строку.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        if (str is " ")
            Console.WriteLine(string.Empty);
        else
            Console.WriteLine(new string(str.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1])); // #1
    }

    static void String40()
    {
        //String40.Дана строка, содержащая по крайней мере один символ пробела.
        //Вывести подстроку, расположенную между первым и последним пробелом
        //исходной строки. Если строка содержит только один пробел, то вывести пустую строку
        Console.Write("Enter string: ");
        string str = Console.ReadLine()!;
        var lines = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (lines.Length < 2)
            Console.WriteLine(string.Empty);
        else
            for (int i = 1; i < lines.Length - 1; i++)
                Console.Write(lines[i] + " ");
    }

    static void String41()
    {
        // String 41. Дана строка, состоящая из русских слов,
        // разделенных пробелами (одним или несколькими). Найти количество слов в строке.

        Console.Write("Enter text: ");
        string text = Console.ReadLine()!;
        Console.WriteLine($"Quantity of words: {text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length}");
    }

    static void String42()
    {
        //String42. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами(одним или несколькими).
        //Найти количество слов, которые начинаются и заканчиваются одной и той же буквой
        Console.Write("Enter original string: ");
        string originalString = Console.ReadLine()!;
        var lines = originalString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;
        foreach (string line in lines)
        {
            if (string.Compare(line.First().ToString(), line.Last().ToString(),
                    StringComparison.OrdinalIgnoreCase) is 0)
                counter++;
        }

        Console.WriteLine(counter);
    }

    static void String42_2(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(words.Count(w => char.ToUpperInvariant(w[0]) == char.ToUpperInvariant(w[^1])));
    }

    static void String42_3()
    {
        string str = Console.ReadLine()!;
        Console.WriteLine(str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(s => s.First() == s.Last()));
    }

    public static void String43()
    {
        /*String43. Дана строка, состоящая из русских слов, набранных заглавными
        буквами и разделенных пробелами (одним или несколькими). Найти ко
        личество слов, которые содержат хотя бы одну букву «А».
         */
        string str = Console.ReadLine()!;
        Console.WriteLine(str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(s => s.Contains('А')));
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
    
    public static void String47()
    {
        /*String47. Дана строка, состоящая из русских слов, разделенных пробелами
        (одним или несколькими). Вывести строку, содержащую эти же слова,
        разделенные однимсимволом«.»(точка).Вконцестрокиточкунеставить.
        */
        string str = Console.ReadLine()!;
        string[] array = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string result = string.Join(".", array);
        Console.WriteLine(result);
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
        String27();
        Console.ReadLine();
        
        // if (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out _))
        //      Console.WriteLine("It's a float number");
    }
}