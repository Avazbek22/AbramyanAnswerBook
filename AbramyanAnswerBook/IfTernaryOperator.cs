// IfTernaryOperator: 1-2, 6-8, 29

// SimpleCode: https://www.youtube.com/watch?v=iQhVp4TGf64
// Путь к сеньору: https://www.youtube.com/watch?v=tm8Y7oWModk&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=11


// If 1. Дано целое число. Если оно является положительным, то прибавить к  нему 1;
// в противном случае не изменять его. Вывести полученное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// n = (n > 0) ? n + 1 : n;
// Console.WriteLine(n);

// If2. Дано целое число. Если оно является положительным, то прибавить к  нему 1;
// в противном случае вычесть из него 2. Вывести полученное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// n = (n > 0) ? n + 1 : n - 2;
// Console.WriteLine(n);

// If 6. Даны два числа. Вывести большее из них.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine(a > b ? a : b);

// If 7. Даны два числа. Вывести порядковый номер меньшего из них.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine(a < b ? 1 : 2);

// If 8. Даны два числа. Вывести вначале большее, а затем меньшее из них.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine(a > b ? $"{a}, {b}" : $"{b}, {a}");

// If29. Дано целое число. Вывести его строку-описание вида «отрицательное четное число», «нулевое число», «положительное нечетное число» и т. д.
// Variant #2
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n == 0)
//     Console.Write("Нулевое число: ");
// else
// {
//     Console.Write(n > 0 ? "Положительное " : "Отрицательное");
//     Console.Write(n % 2 == 0 ? "четное число" : "нечетное число");
// }