// While 4, 5, 17, 18, 20, 21, 24-27

// Путь к сеньору: https://www.youtube.com/watch?v=e8Nm-5QBfqs&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=12&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83

// While 1. Даны положительные числа A и B (A > B).
// На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений).
// Не используя операции умножения и деления, найти длину незанятой части отрезка A.
// Console.Write("A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("B: ");
// int b = int.Parse(Console.ReadLine()!);
// while (a >= b)
// {
//     a -= b;
// }
// Console.WriteLine($"Result: {a}");

//While 2. Даны положительные числа A и B (A > B).
//На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений).
//Не используя операции умножения и деления, найти количество отрезков B, размещенных на отрезке A.
// Console.Write("A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("B: ");
// int b = int.Parse(Console.ReadLine()!);
// int result = 0;
// while (b <= a)
// {
//     a -= b;
//     result++;
// }
// Console.WriteLine(result);


//While 3. Даны целые положительные числа N и K.
//Используя только операции сложения и вычитания, найти частное от деления нацело N на K,
//а также остаток от этого деления.
// Console.Write("N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("K: ");
// int k = int.Parse(Console.ReadLine()!);
// int quotient = 0;
// while (k <= n)
// {
//     n -= k;
//     quotient++;
// }
// Console.WriteLine($"Quotient: {quotient}");
// Console.WriteLine($"Reminder: {n}");

// While 4. Дано целое число N (>0). Если оно является степенью числа 3,
//то вывести TRUE, если не является  вывести FALSE.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n >= 3 && n % 3 == 0)
// {
//     n /= 3;
// }
// Console.WriteLine(n == 1);

// While 5. Дано целое число N (> 0), являющееся некоторой степенью числа 2:
// N = 2^K. Найти целое число K — показатель этой степени
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 0;
// while (n > 1)
// {
//     n /= 2;
//     k++;
// }
// Console.WriteLine($"K: {k}");

// While 7. Дано целое число N (> 0). Найти наименьшее целое положительное число K, квадрат которого превосходит N:
// K^2 > N. Функцию извлечения квадратного корня не использовать.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 1;
// while (k * k <= n) 
// {
//     k++;
// }
// Console.WriteLine($"K: {k}");

// While 8. Дано целое число N (> 0). Найти наибольшее целое число K, квадрат которого не превосходит N:
// K 2 ≤ N. Функцию извлечения квадратного корня не использовать.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 1;
// while (k * k <= n)
// {
//     k++;
// }
// Console.WriteLine($"K: {--k}");

// While 9. Дано целое число N (> 1). Найти наименьшее целое число K, при котором выполняется неравенство 3K > N.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 0, power = 1; 
// while (power <= n)
// {
//     power *= 3;
//     k++;
// }
// Console.WriteLine($"K: {k}");

// While 10. Дано целое число N (> 1). Найти наибольшее целое число K, при котором выполняется неравенство 3K < N.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 0, power = 1;
// while (power * 3 < n)
// {
//     power *= 3;
//     k++;
// }
// Console.WriteLine($"K: {k}");

// While 11 . Дано целое число N (> 1). Вывести наименьшее из целых чисел K,
// для которых сумма 1 + 2 + . . . + K будет больше или равна N, и саму эту сумму.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 0, sum = 0;
// while (sum < n)
// {
//     k++;
//     sum += k;
// }
// Console.WriteLine($"K = {k}, Сумма = {sum}");

// While 12. Дано целое число N (> 1). Вывести наибольшее из целых чисел K,
// для которых сумма 1 + 2 + . . . + K будет меньше или равна N, и саму эту сумму
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 0, sum = 0;
// while (sum + k + 1 <= n)
// {
//     sum += ++k;
// }
// Console.WriteLine($"k = {k}, sum = {sum}");

// While17. Дано целое число N (> 0). Используя операции деления нацело и взятия остатка от деления,
// вывести все его цифры, начиная с самой правой (разряда единиц).
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 0)
// {
//     Console.WriteLine(n % 10);
//     n /= 10;
// }

// While18. Дано целое число N (> 0).
// Используя операции деления нацело и взятия остатка от деления, найти количество и сумму его цифр.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0, count = 0;
// while (n > 0)
// {
//     sum += n % 10;
//     count++;
//     n /= 10;
// }
// Console.WriteLine($"Количество цифр: {count}, Сумма цифр: {sum}");

// While19. Дано целое число N (> 0). Используя операции деления нацело и взятия остатка от деления,
// найти число, полученное при прочтении числа N справа налево.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int reversed = 0;
// while (n > 0)
// {
//     int digit = n % 10;
//     reversed = reversed * 10 + digit;
//     n /= 10;
// }
// Console.WriteLine($"Число наоборот: {reversed}");

//While 20. Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить,
//имеется ли в записи числа N цифра «2». Если имеется, то вывести TRUE, если нет — вывести FALSE.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool hasTwo = false;
// while (n > 0)
// {
//     if (n % 10 == 2)
//         hasTwo = true;
//
//     n /= 10;
// }
// Console.WriteLine(hasTwo);

// While 21. Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить,
// имеются ли в записи числа N нечетные цифры. Если имеются, то вывести TRUE, если нет — вывести FALSE.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool hasOdd = false;
// while (n > 0)
// {
//     if ((n % 10) % 2 == 1)
//         hasOdd = true; 
//     
//     n /= 10;
// }
// Console.WriteLine(hasOdd);

// While 22. Дано целое число N (> 1). Если оно является простым, то есть не имеет положительных делителей,
// кроме 1 и самого себя, то вывести TRUE,иначе вывести FALSE.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool isPrime = n > 1;
// int i = 2;
// while (i * i <= n)
// {
//     if (n % i == 0) 
//         isPrime = false; 
//     
//     i++;
// }
// Console.WriteLine(isPrime);

// While 24. Дано целое число N (> 1). Последовательность чисел Фибоначчи FK определяется следующим образом:
// F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, . . . . Проверить, является ли число N числом Фибоначчи.
// Если является, то вывести TRUE, если нет — вывести FALSE.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 1, f2 = 1, fk = 1;
// while (fk < n) 
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
// }
// Console.WriteLine(fk == n);


// While 25. Дано целое число N (> 1). Найти первое число Фибоначчи, большее N.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 1, f2 = 1, fk = 1;
// while (fk <= n) 
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
// }
// Console.WriteLine(fk);

// While 26. Дано целое число N (> 1), являющееся числом Фибоначчи: N = FK.
// Найти целые числа FK−1 и FK+1 — предыдущее и последующее числа Фибоначчи.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 1, f2 = 1, fk = 1;
// while (fk < n) 
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
// }
// Console.WriteLine($"prev = {f1}, next = {f1 + f2}");

// While 27. Дано целое число N (> 1), являющееся числом Фибоначчи: N = FK
// Найти целое число K — порядковый номер числа Фибоначчи N.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 2;
// int f1 = 1, f2 = 1, fk = 1;
// while (fk < n) 
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
//     k++;
// }
// Console.WriteLine($"k = {k}");