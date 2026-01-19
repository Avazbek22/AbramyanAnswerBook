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
        // String 26. Дано целое число N (> 0) и строка S. Преобразовать строку S в строку длины N следующим образом:
        // если длина строки S больше N, то отбросить первые символы, если длина строки S меньше N,
        // то в ее начало добавить символы «.» (точка).

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;

        string result = (s.Length > n) ? string.Concat(s.TakeLast(n)) : new string('.', n - s.Length) + s;

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

        //string result = s1[..Math.Min(n1, s1.Length)] + s2[^Math.Min(n2, s2.Length)..]; // Range op variant
        //string result2 = s1.Substring(0, Math.Min(n1, s1.Length)) + s2.Substring(Math.Max(0, s2.Length - n2)); // Simple Substring
    }

    static void String28()
    {
        // String 28. Дан символ C и строка S. Удвоить каждое вхождение символа C в строку S.

        Console.Write("Enter C: ");
        char c = char.Parse(Console.ReadLine()!);
        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.WriteLine(s.Replace(c.ToString(), $"{c}{c}"));
    }

    static void String29()
    {
        // String 29. Дан символ C и строки S, S0. Перед каждым вхождением символа C в строку S вставить строку S0.

        Console.Write("Enter C: ");
        char c = char.Parse(Console.ReadLine()!);
        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;;
        Console.Write("Enter S0: ");
        string s0 = Console.ReadLine()!;
        Console.WriteLine(s.Replace(c.ToString(), $"{s0}{c}"));
    }

    static void String30()
    {
        // String 30. Дан символ C и строки S, S0. После каждого вхождения символа C в строку S вставить строку S0.

        Console.Write("Enter C: ");
        char c = char.Parse(Console.ReadLine()!);
        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;;
        Console.Write("Enter S0: ");
        string s0 = Console.ReadLine()!;
        Console.WriteLine(s.Replace(c.ToString(), $"{c}{s0}"));
    }

    static void String31()
    {
        // String 31. Даны строки S и S0. Проверить, содержится ли строка S0 в строке S.
        // Если содержится, то вывести TRUE, если не содержится, то вывести FALSE.

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter S0: ");
        string s0 = Console.ReadLine()!;
        Console.WriteLine(s.Contains(s0));
    }

    static void String32()
    {
        // String 32. Даны строки S и S0. Найти количество вхождений строки S0 в строку S.
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

    static void String33()
    {
        // String 33. Даны строки S и S0. Удалить из строки S первую подстроку, совпадающую с S0.
        // Если совпадающих подстрок нет, то вывести строку S без изменений.

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter S0: ");
        string s0 = Console.ReadLine()!;

        int index = s.IndexOf(s0);

        if (index != -1)
            s = s.Remove(index, s0.Length);

        Console.WriteLine(s);
    }

    static void String34()
    {
        // String 34. Даны строки S и S0. Удалить из строки S последнюю подстроку, совпадающую с S0.
        // Если совпадающих подстрок нет, то вывести строку S без изменений.

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter S0: ");
        string s0 = Console.ReadLine()!;

        int index = s.LastIndexOf(s0);

        if (index != -1)
            s = s.Remove(index, s0.Length);

        Console.WriteLine(s);
    }

    static void String35()
    {
        // String 35. Даны строки S и S0. Удалить из строки S все подстроки, совпадающие с S0.
        // Если совпадающих подстрок нет, то вывести строку S без изменений.

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter S0: ");
        string s0 = Console.ReadLine()!;

        Console.WriteLine(s.Replace(s0, ""));
    }

    static void String36()
    {
        // String 36. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter S1: ");
        string s1 = Console.ReadLine()!;
        Console.Write("Enter S2: ");
        string s2 = Console.ReadLine()!;

        int index = s.IndexOf(s1);

        if (index != -1)
            s = s.Remove(index, s1.Length).Insert(index, s2);

        Console.WriteLine(s);
    }

    static void String37()
    {
        // String 37. Даны строки S, S1 и S2. Заменить в строке S последнее вхождение строки S1 на строку S2.

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter S1: ");
        string s1 = Console.ReadLine()!;
        Console.Write("Enter S2: ");
        string s2 = Console.ReadLine()!;

        int index = s.LastIndexOf(s1);

        if (index != -1)
            s = s.Remove(index, s1.Length).Insert(index, s2);

        Console.WriteLine(s);
    }

    static void String38()
    {
        // String 38. Даны строки S, S1 и S2. Заменить в строке S все вхождения строки S1 на строку S2.

        Console.Write("Enter S: ");
        string s = Console.ReadLine()!;
        Console.Write("Enter S1: ");
        string s1 = Console.ReadLine()!;
        Console.Write("Enter S2: ");
        string s2 = Console.ReadLine()!;

        Console.WriteLine(s.Replace(s1, s2));
    }

    static void String39()
    {
        // String 39. Дана строка, содержащая по крайней мере один символ пробела.
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
        //String 40. Дана строка, содержащая по крайней мере один символ пробела.
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
        // String 42. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами(одним или несколькими).
        // Найти количество слов, которые начинаются и заканчиваются одной и той же буквой
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
        // String 43. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими).
        // Найти количество слов, которые содержат хотя бы одну букву «А».

        string str = Console.ReadLine()!;
        Console.WriteLine(str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(s => s.Contains('А')));
    }

    static void String44()
    {
        // String 44. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими).
        // Найти количество слов, которые содержат ровно три буквы «А».

        Console.Write("Enter a text: ");
        string s = Console.ReadLine()!;
        var count = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(c => c.Count(ch => ch == 'A') == 3);
        Console.WriteLine($"Count: {count}");
    }

    static void String45()
    {
        // String 45. Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Найти длину самого короткого слова.

        Console.Write("Enter a text: ");
        string s = Console.ReadLine()!;
        var minLength = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Min(c => c.Length);
        Console.WriteLine($"Min length: {minLength}");
    }

    static void String47()
    {
        //String 47. Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими).
        //Вывести строку, содержащую эти же слова, разделенные одним символом «.» (точка). В конце строки точку не ставить.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(".", words));
    }

    static void String48()
    {
        // String 48. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими).
        // Преобразовать каждое слово в строке, заменив в нем все последующие вхождения его первой буквы на символ «.» (точка).
        // Например, слово «МИНИМУМ» надо преобразовать в «МИНИ.У.». Количество пробелов между словами не изменять.

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

    static void String49()
    {
        // String 49. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими).
        // Преобразовать каждое слово в строке, заменив в нем все предыдущие вхождения его последней буквы на символ «.» (точка).
        // Например, слово «МИНИМУМ» надо преобразовать в «.ИНИ.УМ». Количество пробелов между словами не изменять.

        // Console.Write("Enter a text: ");
        // string str = Console.ReadLine()!;
        // var words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        // var result = words.Select(w => w = string.Concat(w.sk))
    }

    static void String50()
    {
        // String 50. Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими).
        // Вывести строку, содержащую эти же слова, разделенные одним пробелом и расположенные в обратном порядке.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(string.Join(" ", str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()));
    }

    static void String51()
    {
        // String 51. Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими).
        // Вывести строку, содержащую эти же слова, разделенные одним пробелом и расположенные в алфавитном порядке.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(string.Join(" ", str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Order()));
    }

    static void String52()
    {
        // String 52. Дана строка-предложение на русском языке. Преобразовать строку так, чтобы каждое слово начиналось с заглавной буквы.
        // Словом считать набор символов, не содержащий пробелов и ограниченный пробелами или началом/концом строки. Слова, не начинающиеся с буквы, не изменять

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        string result = string.Join(" ", str.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(w => char.IsLetter(w[0]) ? char.ToUpper(w[0]) + w[1..] : w)
        );

        Console.WriteLine(result);
    }

    static void String53()
    {
        // String 53. Дана строка-предложение на русском языке. Подсчитать количество содержащихся в строке знаков препинания.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(str.Count(char.IsPunctuation));
    }

    static void String54()
    {
        // String 54. Дана строка-предложение на русском языке. Подсчитать количество содержащихся в строке гласных букв.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;

        const string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

        Console.WriteLine(str.Count(c => vowels.Contains(c)));
    }

    static void String55()
    {
        // String 55. Дана строка-предложение на русском языке. Вывести самое длинное слово в предложении.
        // Если таких слов несколько, то вывести первое из них. Словом считать набор символов, не содержащий пробелов,
        // знаков препинания и ограниченный пробелами, знаками препинания или началом/концом строки.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        string[] words = str.Split([' ', '.', ',', '!', '?', ':', ';', '-', '—', '(', ')', '"', '\''], StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Max(w => w.Length));
    }

    static void String56()
    {
        // String 56. Дана строка-предложение на русском языке. Вывести самое короткое слово в предложении.
        // Если таких слов несколько, то вывести последнее из них. Словом считать набор символов, не содержащий пробелов,
        // знаков препинания и ограниченный пробелами, знаками препинания или началом/концом строки.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        string[] words = str.Split([' ', '.', ',', '!', '?', ':', ';', '-', '—', '(', ')', '"', '\''], StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Min(w => w.Length));
    }

    static void String57()
    {
        // String 57. Дана строка-предложение с избыточными пробелами между слова
        // ми. Преобразовать ее так, чтобы между словами был ровно один пробел.

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;

        // Это разбивает по любым пробельным символам (пробел, табуляция, перевод строки и т.д.).
        // Фишка в том, что null в Split((char[])null, ...) означает использовать все стандартные пробельные символы. Без него Split() не сможет разбить табуляцию!
        Console.WriteLine(string.Join(" ", str.Split((char[])null!, StringSplitOptions.RemoveEmptyEntries)));
    }


    static void String58()
    {
        // String 58. Дана строка, содержащая полное имя файла, то есть имя диска, список каталогов (путь), собственно имя и расширение.
        // Выделить из этой строки имя файла (без расширения)

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(string.Concat(str.Split('\\').Last().TakeWhile(c => c != '.')));
    }

    static void String58_2()
    {
        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(Path.GetFileNameWithoutExtension(str)); // Получаем имя файла без расширения
    }

    static void String59()
    {
        // String 59. Дана строка, содержащая полное имя файла, то есть имя диска, список каталогов (путь), собственно имя и расширение.
        // Выделить из этой строки расширение файла (без предшествующей точки).

        Console.Write("Enter a text: ");
        string str = Console.ReadLine()!;
        Console.WriteLine(string.Concat(str.Split('\\').Last().SkipWhile(c => c != '.').Skip(1)));
    }

    static void String60()
    {
        // String 60. Дана строка, содержащая полное имя файла. Выделить из этой строки название первого каталога (без символов «\»).
        // Если файл содержится в корневом каталоге, то вывести символ «\».

        Console.Write("Enter full path: ");
        string path = Console.ReadLine()!;
        string[] parts = path.Split('\\', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(parts.Length <= 2 ? "\\" : parts[1]);
    }

    static void String61()
    {
        // String 61. Дана строка, содержащая полное имя файла. Выделить из этой строки название последнего каталога (без символов «\»).
        // Если файл содержится в корневом каталоге, то вывести символ «\».

        Console.Write("Enter full path: ");
        string path = Console.ReadLine()!;
        string[] parts = path.Split('\\', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(parts.Length <= 2 ? "\\" : parts[^2]);
    }

    static void String62()
    {
        // String 62. Дана строка-предложение на русском языке. Зашифровать ее, выполнив циклическую замену каждой буквы на следующую за ней в алфавите
        // и сохранив при этом регистр букв («А» перейдет в «Б», «а» — в «б», «Б» — в «В», «я» — в «а» и т. д.).
        // Букву «ё» в алфавите не учитывать («е» должна переходить в «ж»). Знаки препинания и пробелы не изменять.


    }

    static void String63()
    {
        // String 63. Дана строка-предложение на русском языке и число K (0 < K < 10).
        // Зашифровать строку, выполнив циклическую замену каждой буквы на букву того же регистра, расположенную в алфавите на K-й позиции после шифруемой буквы
        // (например, для K = 2 «А» перейдет в «В», «а» — в «в», «Б» — в «Г», «я» — в «б» и т. д.). Букву «ё» в алфавите не учитывать, знаки препинания и пробелы не изменять

        Console.Write("Введите ключ: ");
        int key = int.Parse(Console.ReadLine()!);
        Console.Write("Введите текст: ");
        string text = Console.ReadLine()!; // храню фразу, которую буду шифровать
        string result = string.Empty; // храню результат шифрования
        int letterNumber;
        string rusLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; // работаю с английским алфавитом
        string engLetters = "abcdefghijklmnopqrstuvwxyz";// // работаю с русским алфавитом
        for (int i = 0; i < text.Length; i++) // цикл перебора букв шифруемого слова
        {
            for (int j = 0; j < engLetters.Length; j++) // цикл сравнения каждой буквы с алфавитом
            {
                if (text[i] == engLetters[j]) // в случае совпадения, создаю переменную, где храню номер буквы со сдвигом
                {
                    letterNumber = j + key; // номер буквы + сдвиг по ключу

                    while (letterNumber >= engLetters.Length) // чтобы новая буква не уходила за рамки алфавита
                        letterNumber -= engLetters.Length;

                    result += engLetters[letterNumber]; // заношу зашифрованную букву в переменную, для ее хранения
                }

                else if (text[i] == ' ')
                    result += " ";
            }
        }
        Console.WriteLine("Зашифрованное слово: " + result);
        Console.ReadLine();
    }

    public static void Main()
    {
        // Изучить StringBuilder
        String59();
        Console.ReadLine();

        // if (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out _))
        //      Console.WriteLine("It's a float number");
    }
}