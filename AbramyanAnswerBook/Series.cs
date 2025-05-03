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
//
// // Variant #2
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


// Series29. Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе.
// Вывести общую сумму всех элементов, входящих в данные наборы.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 1; i <= k; i++)
// {
//     Console.WriteLine($"{i} Set:");
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"[{j}] = ");
//         sum += int.Parse(Console.ReadLine()!);
//     }
// }
// Console.WriteLine($"Total sum: {sum}");


// Series 30. Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе.
// Для каждого набора вывести сумму его элементов
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= k; i++)
// {
//     int sum = 0;
//     Console.WriteLine($"{i} Set:");
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"[{j}] = ");
//         sum += int.Parse(Console.ReadLine()!);
//     }
//     Console.WriteLine($"Sum of {i} set is: {sum}");
// }


// Series 31. Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе.
// Найти количество наборов, содержащих число 2. Если таких наборов нет, то вывести 0.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int count = 0, num;
// for (int i = 1; i <= k; i++)
// {
//     bool hasSequenceTwo = false;
//     Console.WriteLine($"{i} Set:");
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"[{j}] = ");
//         num = int.Parse(Console.ReadLine()!);
//         if (num == 2)
//             hasSequenceTwo = true;
//     }
//
//     if (hasSequenceTwo)
//         count++;
// }
// Console.WriteLine($"Count of sets containing the number 2 is: {count}");


// Series 32. Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе.
// Для каждого набора вывести номер его первого элемента, равного 2, или число 0, если в данном наборе нет двоек.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 1, num; i <= k; i++)
// {
//     int firstIndex = 0;
//     Console.WriteLine($"{i} Set:");
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"[{j}] = ");
//         num = int.Parse(Console.ReadLine()!);
//         if (num == 2 && firstIndex == 0)
//             firstIndex = j;
//     }
//     Console.WriteLine(firstIndex != 0 ? $"First index: {firstIndex}" : "0");
// }


// Series 33. Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе.
// Для каждого набора вывести номер его последнего элемента, равного 2, или число 0, если в данном наборе нет двоек.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 1, num; i <= k; i++)
// {
//     int lastIndex = 0;
//     Console.WriteLine($"{i} Set:");
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"[{j}] = ");
//         num = int.Parse(Console.ReadLine()!);
//         if (num == 2)
//             lastIndex = j;
//     }
//     Console.WriteLine(lastIndex != 0 ? $"Last index: {lastIndex}" : "0");
// }


// Series 34. Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе.
// Для каждого набора выполнить следующее действие:
// если в наборе содержится число 2, то вывести сумму его элементов; если в наборе нет двоек, то вывести 0.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 1, num; i <= k; i++)
// {
//     int sum = 0;
//     bool hasSequenceTwo = false;
//     Console.WriteLine($"{i} Set:");
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"[{j}] = ");
//         num = int.Parse(Console.ReadLine()!);
//         sum += num;
//         
//         if (num == 2)
//             hasSequenceTwo = true;
//     }
//     Console.WriteLine(hasSequenceTwo ? $"Sum: {sum}" : "0");
// }


// Series 35. Дано целое число K, а также K наборов ненулевых целых чисел.
// Признаком завершения каждого набора является число 0.
// Для каждого набора вывести количество его элементов. Вывести также общее количество элементов во всех наборах.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// int totalCount = 0;
// for (int i = 1; i <= k; i++)
// {
//     int number, count = 0;
//     Console.WriteLine($"{i} Set:");
//     do
//     {
//         Console.Write($"Number: ");
//         number = int.Parse(Console.ReadLine()!);
//         count++;
//
//     } while (number != 0);
//
//     totalCount += --count;
//     Console.WriteLine($"Numbers count of {i} set is: {count}");
// }
// Console.WriteLine($"Total count: {totalCount}");


// Series 36. Дано целое число K, а также K наборов ненулевых целых чисел.
// Каждый набор содержит не менее двух элементов, признаком его завершения является число 0.
// Найти количество наборов, элементы которых возрастают
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// int countOfIncreasingSequences = 0;
// for (int i = 1; i <= k; i++)
// {
//     bool isIncreasingSequence = true;
//     int current, previous = int.MinValue;
//     Console.WriteLine($"{i} Set:");
//     do
//     {
//         Console.Write($"Number: ");
//         current = int.Parse(Console.ReadLine()!);
//         if (current <= previous && current != 0)
//             isIncreasingSequence = false;
//
//         previous = current;
//
//     } while (current != 0);
//
//     if (isIncreasingSequence)
//         countOfIncreasingSequences++;
// }
// Console.WriteLine($"Count of increasing sequences: {countOfIncreasingSequences}");