//For: 1-20, 33, 36-40

// Путь к сеньору: https://www.youtube.com/watch?v=JYhw1vBQ9KU&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=13&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83

// For 1. Даны целые числа K и N (N > 0). Вывести N раз число K.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(k);
// }  


// For 2. Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа,
// расположенные между A и B (включая сами числа A и B), а также количество N этих чисел.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = a; i <= b; i++)
// {
//     Console.WriteLine(i);
// }
//
// Console.WriteLine($"Count: {b - a + 1}");


// For 3. Даны два целых числа A и B (A < B). Вывести в порядке убывания все целые числа,
// расположенные между A и B (не включая числа A и B), а также количество N этих чисел.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = b; i >= a; i--)
// {
//     Console.WriteLine(i);
// }
//
// Console.WriteLine($"Count: {b - a + 1}");


// For 4. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1, 2, . . . , 10 кг конфет
// Console.Write("Enter price for candies: ");
// decimal price = decimal.Parse(Console.ReadLine()!);
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"Price for {i} kg = {price * i}");
// }


// For 5. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1, 0.2, . . . , 1 кг конфет.
// Console.Write("Enter price for candies: ");
// decimal price = decimal.Parse(Console.ReadLine()!);
// for (decimal i = 0.1m; i <= 1; i += 0.1m)
// {
//     Console.WriteLine($"Price for {i} kg = {price * i}");
// }

// For 5. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1, 0.2, . . . , 1 кг конфет.
// Variant #2
// Console.Write("Enter price for candies: ");
// decimal price = decimal.Parse(Console.ReadLine()!);
// for (decimal i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"Price for {i * 0.1m} kg = {price * i * 0.1m}");
// }

// For 6. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2, 1.4, . . . , 2 кг конфет.
// Console.Write("Enter price for candies: ");
// decimal price = decimal.Parse(Console.ReadLine()!);
// for (decimal i = 1.2m; i <= 2; i += 0.2m)
// {
//     Console.WriteLine($"Price for {i} kg = {price * i}");
// }

// For 7. Даны два целых числа A и B (A < B). Найти сумму всех целых чисел от A до B включительно.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = a; i <= b; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Sum = {sum}");

// For 8. Даны два целых числа A и B (A < B). Найти произведение всех целых чисел от A до B включительно.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// int product = 1;
// for (int i = a; i <= b; i++)
// {
//     product *= i;
// }
// Console.WriteLine($"Product = {product}");

// For 9. Даны два целых числа A и B (A < B). Найти сумму квадратов всех целых чисел от A до B включительно.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = a; i <= b; i++)
// {
//     sum += i * i;
// }
// Console.WriteLine($"Sum of squares = {sum}");

// For 10. Дано целое число N (> 0). Найти сумму 1 + 1/2 + 1/3 + . . . + 1/N (вещественное число).
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     sum += 1.0m / i;
// }
// Console.WriteLine($"Sum = {sum}");

// For 11. Дано целое число N (> 0). Найти сумму N^2 + (N + 1)^2 + (N + 2)^2 + . . . + (2·N)^2
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum += (n + i) * (n + i);
// }
// Console.WriteLine($"Sum = {sum}");

// For 12. Дано целое число N (> 0). Найти произведение 1.1 · 1.2 · 1.3 · . . .
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal product = 1.1m, j = 1.2m;
// for (int i = 1; i <= n; i++, j += 0.1m)
// {
//     product *= j;
//     Console.WriteLine(product);
// }
// Console.WriteLine($"Product = {product}");

// For 13◦. Дано целое число N (> 0). Найти значение выражения 1.1 − 1.2 + 1.3 − . . .
// (N слагаемых, знаки чередуются). Условный оператор не использовать.
// Variant #1
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal product = 0;
// int sign = -1;
// for (int i = 1; i <= n; i++)
// {
//     sign *= -1;
//     product += sign * (1 + 0.1m * i);
//     Console.WriteLine(product);
// }

// For 13. Дано целое число N (> 0). Найти значение выражения 1.1 − 1.2 + 1.3 − . . .
// Variant #2
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal result = 1.1m;
// for (decimal i = 0, j = 1.2m; i < n; i++, j += 0.1m)
// {
//     result -= j;
//     Console.WriteLine(result);
//     j+=0.1m;
//     i++;
//     result += j;
//     Console.WriteLine(result);
// }

// For 14. Дано целое число N (> 0). Найти квадрат данного числа,
// используя для его вычисления следующую формулу:N^2 = 1 + 3 + 5 + . . . + (2·N − 1).
// Variant #1
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 0, j = 1; i < n; i++, j+=2)
// {
//     sum += j;
// }
//
// Console.WriteLine(sum);

// For 14. Дано целое число N (> 0). Найти квадрат данного числа,
// используя для его вычисления следующую формулу:N^2 = 1 + 3 + 5 + . . . + (2·N − 1).
// Variant #2
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 0;
// for (int i = 1; i <= n; i++)
// {
//     result += 2 * i - 1; 
// }
// Console.WriteLine($"Result = {result}");

// For 15. Дано вещественное число A и целое число N (> 0). Найти A в степени N: A^N = A·A· . . . ·A (Метод для возведения в степень не использовать).
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 1;
// for (int i = 0; i < n; i++)
// {
//     result *= a;
// }
// Console.WriteLine($"Result = {result}");

// For 16. Дано вещественное число A и целое число N (> 0). Используя один цикл, вывести все целые степени числа A от 1 до N.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 1;
// for (int i = 0; i < n; i++)
// {
//     result *= a;
//     Console.WriteLine(result);
// }

// For 17. Дано вещественное число A и целое число N (> 0). Используя один цикл, найти сумму 1 + A + A^2 + A^3 + . . . + A^N .
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 1, sum = 0;
// for (int i = 0; i < n; i++)
// {
//     result *= a;
//     sum += result;
// }
// Console.WriteLine($"Sum = {sum}");

// For 18. Дано вещественное число A и целое число N (>0). Используя один цикл, найти значение выражения 1+A+A^2 A^3+ +( 1)^N*A^N
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int degree = a, sum = 0;
// for (int i = 1; i < n; i++)
// {
//     degree *= a;
//     sum += degree;
//     degree *= -1;
//     Console.WriteLine(sum);
// }

// For 19. Дано целое число N (> 0). Найти произведение N! = 1·2·. . .·N (N–факториал).
// Чтобы избежать целочисленного переполнения, вычислять это произведение с помощью вещественной переменной и вывести его как вещественное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal factorial = 1;
// for (int i = 2; i <= n; i++)
// {
//     factorial *= i;
// }
// Console.WriteLine($"Result = {factorial}");

// For 20. Дано целое число N (> 0). Используя один цикл, найти сумму 1! + 2! + 3! + . . . + N!
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal factorial = 1, sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     factorial *= i;
//     sum += factorial;
// }
// Console.WriteLine($"Sum = {sum}");
    
// For 33. Дано целое число N (> 1). Последовательность чисел Фибоначчи FK (целого типа) определяется следующим образом:
// F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, . . . .
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 0, f2 = 1, fk = 0;
// Console.Write(f1 + " ");
// for (int i = 1; i < n; i++)
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
//     Console.Write(fk + " ");
// }

// For 36. Даны целые положительные числа N и K. Найти сумму 1^K + 2^K + . . . + N^K.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// int result = 0;
// for (int i = 1; i <= n; i++)
// {
//     int power = 1;
//     for (int j = 0; j < k; j++)
//     {
//         power *= i;
//     }
//     result += power;
//     Console.WriteLine(result);
// }

// For37. Дано целое число N (> 0). Найти сумму1^1 + 2^2 + . . . + N^N .
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     int power = 1;
//     for (int j = 1; j <= i; j++)
//     {
//         power *= i;
//     }
//
//     sum += power;
//     Console.Write(sum + " ");
// }

// For38. Дано целое число N (> 0). Найти сумму 1^N + 2^N−1 + . . . + N^1
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     int power = 1;
//     for (int j = 0; j <= n - i; j++)
//     {
//         power *= i;
//     }
//
//     sum += power;
//     Console.Write(sum + " ");
// }

// For39. Даны целые положительные числа A и B (A < B).
// Вывести все целые числа от A до B включительно; при этом каждое число должно выводиться столько раз,
// каково его значение (например, число 3 выводится 3 раза).
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = a; i <= b; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write(i + " ");
//     }
// }

// For40. Даны целые числа A и B (A < B). Вывести все целые числа от A до B включительно;
// при этом число A должно выводиться 1 раз, число A + 1 должно выводиться 2 раза и т. д.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = a; i <= b; i++)
// {
//     for (int j = 0; j <= i - a; j++) 
//     {
//         Console.Write(i + " ");
//     }
// }
