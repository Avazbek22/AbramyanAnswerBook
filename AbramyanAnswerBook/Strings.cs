// using System.Globalization;
//
// namespace AbramyanAnswerBook;
//
// public class Strings
// {
//     public static void Main()
//     {
//         // Изучить StringBuilder
//         String58();
//     }
//     
//     static void String7()
//     {
//         Console.Write("Enter text: ");
//         string str = Console.ReadLine()!;
//         Console.WriteLine($"First code: {(int) str.First()}");
//         Console.WriteLine($"Last code: {(int) str.Last()}");
//     }
//
//     static void String9()
//     {
//         Console.Write("Enter N: ");
//         int n = int.Parse(Console.ReadLine()!);
//         Console.Write("Enter C1: ");
//         char c1 = char.Parse(Console.ReadLine()!);
//         Console.Write("Enter C2: ");
//         char c2 = char.Parse(Console.ReadLine()!);
//         for (int i = 0; i < n / 2; i++)
//             Console.Write($"{c1}{c2}");
//
//         string s = "HEllo";
//         Console.WriteLine();
//     }
//
//     static void String14()
//     {
//         Console.Write("Enter a text: ");
//         Console.WriteLine($"Count of upper letters: {Console.ReadLine()!.Count(char.IsUpper)}");
//         
//         if (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out _))
//             Console.WriteLine("It's a float number");
//     }
//
//     static void String22()
//     {
//         Console.Write("Enter a text: ");
//         Console.WriteLine($"Sum: {Console.ReadLine()!.Select(Convert.ToInt32).Sum()}");
//     }
//
//     static void String44()
//     {
//         Console.Write("Enter a text: ");
//         string s = Console.ReadLine()!;
//         var count = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(c => c.Count(ch => ch == 'A') == 3);
//         Console.WriteLine($"Count: {count}");
//     }
//
//     static void String45()
//     {
//         Console.Write("Enter a text: ");
//         string s = Console.ReadLine()!;
//         var minLength = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Min(c => c.Length);
//         Console.WriteLine($"Min length: {minLength}");
//     }
//
//     static void String48()
//     {
//         Console.Write("Enter a text: ");
//         string str = Console.ReadLine()!;
//         var words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//         for (int i = 0; i < words.Length; i++)
//         {
//             words[i] = new string(words[i]
//                 .Select((c, index) => index == 0 ? c : (c == words[i][0] ? '.' : c))
//                 .ToArray());
//         }
//
//         Console.WriteLine($"Result: {string.Join(' ', words)}");
//     }
//     
//     static void String57_2()
//     {
//         // String57. Дана строка-предложение с избыточными пробелами между слова
//         // ми. Преобразовать ее так, чтобы между словами был ровно один пробел.
//         string s = Console.ReadLine()!;
//         // Это разбивает по любым пробельным символам (пробел, табуляция, перевод строки и т.д.).
//         // Фишка в том, что null в Split((char[])null, ...) означает использовать все стандартные пробельные символы.
//         string t = String.Join(" ", s.Split((char[])null!, StringSplitOptions.RemoveEmptyEntries)); 
//         Console.WriteLine(t);
//     }
//
//
//     static void String58()
//     {
//         Console.Write("Enter a text: ");
//         string str = Console.ReadLine()!;
//         string fileName = new string(str.Split('\\').Last().TakeWhile(c => c != '.').ToArray());
//         Console.WriteLine(fileName);
//     }
//     
//     static void String58_3()
//     {
//         string s = Console.ReadLine()!;
//         // Получаем имя файла без расширения
//         string fileName = Path.GetFileNameWithoutExtension(s);
//         Console.WriteLine(fileName);
//     }
//
// }