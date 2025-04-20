// Series: 1-4, 8, 10-16, 19-22, 29-36

// Series 1. Даны десять вещественных чисел. Найти их сумму
// Variant #1
// double sum = 0;
// for (int i = 1; i <= 10 ; i++)
// {
//     Console.Write($"[{i}] = ");
//     sum += double.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Sum: {sum}");

// Variant #2
// Console.Write("Enter a sequence of 10 numbers in line: ");
// Console.WriteLine("Sum: " + Console.ReadLine()!.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum());


// Series 2. Даны десять вещественных чисел. Найти их произведение
// double product = 1;
// for (int i = 1; i <= 10; i++)
// {
//     Console.Write($"[{i}] = ");
//     product *= double.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Product: {product}");


// Series 3. Даны десять вещественных чисел. Найти их среднее арифметическое.
// Variant #1
// double sum = 0;
// for (int i = 1; i <= 10 ; i++)
// {
//     Console.Write($"[{i}] = ");
//     sum += double.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Average: {sum / 10}");

// Variant #2
// Console.Write("Enter a sequence of 10 numbers in line: ");
// Console.WriteLine("Average: " + Console.ReadLine()!.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum() / 10);


// Series 4. Дано целое число N и набор из N вещественных чисел. Вывести сумму и произведение чисел из данного набора.
// double sum = 0, product = 1, number;
// for (int i = 1; i <= 10; i++)
// {
//     Console.Write($"[{i}] = ");
//     number = int.Parse(Console.ReadLine()!);
//     sum += number;
//     product *= number;
// }
// Console.WriteLine($"Sum: {sum}");
// Console.WriteLine($"Product: {product}");


// Series 8. Дано целое число N и набор из N целых чисел.
// Вывести в том же порядке все четные числа из данного набора и количество K таких чисел.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 0;
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"[{i}] = ");
//     int number = int.Parse(Console.ReadLine()!);
//     if (number % 2 == 0)
//     {
//         Console.WriteLine(number);
//         k++;
//     }
// }
// Console.WriteLine($"Even numbers count: {k}");


// Series 10. Дано целое число N и набор из N целых чисел.
// Если в наборе имеются положительные числа, то вывести TRUE; в противном случае вывести FALSE.
// Variant #1
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool hasPositiveNumber = false;
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"[{i}] = ");
//     int number = int.Parse(Console.ReadLine()!);
//     if (number > 0)
//         hasPositiveNumber = true;
// }
// Console.WriteLine(hasPositiveNumber);

// Variant #2
// Console.Write("Enter N: ");
// Console.WriteLine("Sum: " + Enumerable.Range(0, int.Parse(Console.ReadLine()!) + 1).Select(n => int.Parse(Console.ReadLine()!)).Any(n => n > 0));


// Series 11. Даны целые числа K, N и набор из N целых чисел. Если в наборе имеются числа, меньшие K, то вывести TRUE; в противном случае вывести FALSE.
// Variant #1
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// bool hasLessThanK = false;
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"[{i}] = ");
//     int number = int.Parse(Console.ReadLine()!);
//     if (number < k)
//         hasLessThanK = true;
// }
// Console.WriteLine(hasLessThanK);

// Variant #2
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// Console.WriteLine("Sum: " + Enumerable.Range(0, int.Parse(Console.ReadLine()!) + 1).Select(n => int.Parse(Console.ReadLine()!)).Any(n => n < k));


// Series 12. Дан набор ненулевых целых чисел; признак его завершения — число 0. Вывести количество чисел в наборе.
// Variant #1
// int n = -1, count = 0;
// while (n != 0)
// {
//     Console.Write("Enter a number: ");
//     n = int.Parse(Console.ReadLine()!);
//     count++;
// }
// Console.WriteLine($"Count: {--count}");

// Variant #2
// int count = 0;
// do
// {
//     Console.Write("Enter a number: ");
//     count++;
// } while (int.Parse(Console.ReadLine()!) != 0);
// Console.WriteLine($"Count: {--count}");


// Series 13. Дан набор ненулевых целых чисел; признак его завершения — число 0.
// Вывести сумму всех положительных четных чисел из данного набора. Если требуемые числа в наборе отсутствуют, то вывести 0.
// Variant #1
// int n = -1, sum = 0;
// while (n != 0)
// {
//     Console.Write("Enter a number: ");
//     n = int.Parse(Console.ReadLine()!);
//     if (n > 0 && n % 2 == 0)
//         sum += n;
// }
// Console.WriteLine($"Sum: {sum}");

// Variant #2
// int sum = 0, number;
// do
// {
//     Console.Write("Enter a number: ");
//     number = int.Parse(Console.ReadLine()!);
//     if (number > 0 && number % 2 == 0)
//         sum += number;
//     
// } while (number != 0);
// Console.WriteLine($"Sum: {sum}");


// Series 14. Дано целое число K и набор ненулевых целых чисел;
// признак его завершения — число 0. Вывести количество чисел в наборе, меньших K.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// int count = 0, number = 1;
// while (number != 0)
// {
//     Console.Write("Enter a number: ");
//     number = int.Parse(Console.ReadLine()!);
//     if (number < k)
//         count++;
// }
//
// Console.WriteLine($"Count: {count}");


// Series 15. Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0.
// Вывести номер первого числа в наборе, большего K. Если таких чисел нет, то вывести 0.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// int index = 0, num = 1, iterator = 0;
// while (num != 0)
// {
//     Console.Write("Enter a number: ");
//     num = int.Parse(Console.ReadLine()!);
//     iterator++;
//     if (num > k && index == 0)
//         index = iterator;
// }
// Console.WriteLine($"Index: {index}");


// Series 16. Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0.
// Вывести номер последнего числа в наборе, большего K. Если таких чисел нет, то вывести 0.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// int index = 0, num = 1, iterator = 0;
// while (num != 0)
// {
//     Console.Write("Enter a number: ");
//     num = int.Parse(Console.ReadLine()!);
//     iterator++;
//     if (num > k)
//         index = iterator;
// }
// Console.WriteLine($"Index: {index}");


// Series 19. Дано целое число N (> 1) и набор из N целых чисел.
// Вывести те элементы в наборе, которые меньше своего левого соседа, и количество K таких элементов.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int current, count = 0, previous = int.MinValue;
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"[{i}] = ");
//     current = int.Parse(Console.ReadLine()!);
//     if (current < previous)
//     {
//         count++;
//         Console.WriteLine(current);
//     }
//
//     previous = current;
// }
// Console.WriteLine($"Count: {count}");


// Series20. Дано целое число N (> 1) и набор из N целых чисел.
// Вывести те элементы в наборе, которые меньше своего правого соседа, и количество K таких элементов.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int current, count = 0, previous = int.MaxValue;
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"[{i}] = ");
//     current = int.Parse(Console.ReadLine()!);
//     if (current > previous)
//     {
//         count++;
//         Console.WriteLine(current);
//     }
//
//     previous = current;
// }
// Console.WriteLine($"Count: {count}");


// Series 21. Дано целое число N (> 1) и набор из N вещественных чисел.
// Проверить, образует ли данный набор возрастающую последовательность. Если образует, то вывести TRUE, если нет — вывести FALSE
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool isIncreasingSequence = true;
// int current, previous = int.MinValue;
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"[{i}] = ");
//     current = int.Parse(Console.ReadLine()!);
//     if (current <= previous)
//         isIncreasingSequence = false;
//
//     previous = current;
// }
// Console.WriteLine(isIncreasingSequence);


// Series22. Дано целое число N (> 1) и набор из N вещественных чисел.
// Если данный набор образует убывающую последовательность, то вывести 0;
// в противном случае вывести номер первого числа, нарушающего закономерность.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int current, index = 0, previous = int.MaxValue;
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"[{i}] = ");
//     current = int.Parse(Console.ReadLine()!);
//     if (current > previous && index == 0)
//         index = i;
//         
//     previous = current;
// }
// Console.WriteLine(index != 0 ? $"Index: {index}" : "0");