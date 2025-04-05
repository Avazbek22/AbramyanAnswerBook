// IF: 1-20, 22, 29-30

// Путь к сеньору: https://www.youtube.com/watch?v=avCAbzzcTEM&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=9&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83

// If 1. Дано целое число. Если оно является положительным, то прибавить к нему 1;
// в противном случае не изменять его. Вывести полученное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n > 0)
//     n++;
//
// Console.WriteLine(n);

// If 2. Дано целое число. Если оно является положительным, то прибавить к нему 1;
// в противном случае вычесть из него 2. Вывести полученное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n > 0)
//     n++;
// else 
//     n -= 2;
// Console.WriteLine(n);

// If 3. Дано целое число. Если оно является положительным, то прибавить к нему 1;
// если отрицательным, то вычесть из него 2; если нулевым, то заменить его на 10. Вывести полученное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n > 0)
//     n++;
// else if (n < 0)
//     n -= 2;
// else
//     n = 10;
// Console.WriteLine(n);

// If 4. Даны три целых числа. Найти количество положительных чисел в исходном наборе.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// int positivesCount = 0;
// if (a > 0)
//     positivesCount++;
// if (b > 0)
//     positivesCount++;
// if (c > 0)
//     positivesCount++;
// Console.WriteLine($"Positives count: {positivesCount}");

// If 5. Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// int positivesCount = 0;
// int negativesCount = 0;
// if (a > 0)
//     positivesCount++;
// else if (a < 0)
//     negativesCount++;
// if (b > 0)
//     positivesCount++;
// else if (b < 0)
//     negativesCount++;
// if (c > 0)
//     positivesCount++;
// else if (c < 0)
//     negativesCount++;
//
// Console.WriteLine($"Positives count: {positivesCount}");
// Console.WriteLine($"Negatives count: {negativesCount}");

// If 6. Даны два числа. Вывести большее из них
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     Console.WriteLine(a);
// else if (b > a)
//     Console.WriteLine(b);
// else
//     Console.WriteLine("Numbers are equal");

// If 7. Даны два числа. Вывести порядковый номер меньшего из них.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     Console.WriteLine(2);
// else if (b > a)
//     Console.WriteLine(1);
// else
//     Console.WriteLine("Numbers are equal");


// If 8. Даны два числа. Вывести вначале большее, а затем меньшее из них
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     Console.WriteLine($"{a}\n{b}");
// else if (b > a)
//     Console.WriteLine($"{b}\n{a}");
// else
//     Console.WriteLine("Numbers are equal");

// If 9. Даны две переменные вещественного типа: A, B. Перераспределить значения данных переменных так,
// чтобы в A оказалось меньшее из значений, а в B — большее. Вывести новые значения переменных A и B.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
// {
//     int copyA = a;
//     a = b;
//     b = copyA;
// }
//
// Console.WriteLine($"A: {a}");
// Console.WriteLine($"B: {b}");

// If 10. Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной сумму этих значений,
// а если равны, то присвоить переменным нулевые значения. Вывести новые значения переменных A и B.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a != b)
// {
//     a += b;
//     b = a;
// }
// else
// {
//     a = 0;
//     b = 0;
// }
//
// Console.WriteLine($"A: {a}");
// Console.WriteLine($"B: {b}");

// If 11. Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной большее из этих значений,
// а если равны, то присвоить переменным нулевые значения. Вывести новые значения переменных A и B.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     b = a;
// else if (b > a)
//     a = b;
// else
// {
//     a = 0;
//     b = 0;
// }
//
// Console.WriteLine($"A: {a}");
// Console.WriteLine($"B: {b}");

// If 12. Даны три числа. Найти наименьшее из них.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && a < c)
//     Console.WriteLine(a);
// else if (b < a && b < c)
//     Console.WriteLine(b);
// else if (c < a && c < b)
//     Console.WriteLine(c);

// If 13. Даны три числа. Найти среднее из них (то есть число, расположенное между наименьшим и наибольшим).
/*
 * Варианты:
 * 123
 * 321
 * 132
 * 213
 * 312
 * 231
 */
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a > b && a < c || a < b && a > c)
//     Console.WriteLine(a);
// else if (b > a && b < c || b < a && b > c)
//     Console.WriteLine(b);
// else if (c > a && c < b || c < a && c > b)
//     Console.WriteLine(c);

// If 14. Даны три числа. Вывести вначале наименьшее, а затем наибольшее из данных чисел.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && a < c)
//     Console.WriteLine(a);
// else if (b < a && b < c)
//     Console.WriteLine(b);
// else if (c < a && c < b)
//     Console.WriteLine(c);
//
// if (a > b && a > c)
//     Console.WriteLine(a);
// else if (b > a && b > c)
//     Console.WriteLine(b);
// else if (c > a && c > b)
//     Console.WriteLine(c);

// If 15. Даны три числа. Найти сумму двух наибольших из них
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && a < c)
//     Console.WriteLine(b + c);
// else if (b < a && b < c)
//     Console.WriteLine(a + c);
// else if (c < a && c < b)
//     Console.WriteLine(a + b);

// If 16. Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию, то удвоить их;
// в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных A, B, C.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && b < c)
// {
//     a *= 2;
//     b *= 2;
//     c *= 2;
// }
// else
// {
//     a = -a;
//     b = -b;
//     c = -c;
// }
// Console.WriteLine($"A: {a} B: {b} C: {c}");

// If 17. Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию или убыванию,
// то удвоить их; в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных A, B, C.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && b < c || a > b && b > c)
// {
//     a *= 2;
//     b *= 2;
//     c *= 2;
// }
// else
// {
//     a = -a;
//     b = -b;
//     c = -c;
// }
// Console.WriteLine($"A: {a} B: {b} C: {c}");

// If 18. Даны три целых числа, одно из которых отлично от двух других, равных между собой.
// Определить порядковый номер числа, отличного от остальных.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a == b && c != a)
//     Console.WriteLine(c);
// else if (a == c && b != c)
//     Console.WriteLine(b);
// else if (c == b && a != c)
//     Console.WriteLine(a);
// else
//     Console.WriteLine("Invalid input!");

// If 19. Даны четыре целых числа, одно из которых отлично от трех других, равных между собой.
// Определить порядковый номер числа, отличного от остальных.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// Console.Write("Enter D: ");
// int d = int.Parse(Console.ReadLine()!);
// if (d == b && b == c && a != d)  
//     Console.WriteLine(1);
// else if (d == a && a == c && b != d)  
//     Console.WriteLine(2);
// else if (b == a && a == d && c != d)  
//     Console.WriteLine(3);
// else if (b == a && c == b && d != c)  
//     Console.WriteLine(4);
// else
//     Console.WriteLine("Invalid input!"); 

// If 20. На числовой оси расположены три точки: A, B, C.
// Определить, какая из двух последних точек (B или C) расположена ближе к A, и вывести эту точку и ее расстояние от точки A.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// int distanceAB = Math.Abs(a - b);
// int distanceAC = Math.Abs(a - c);
// if (distanceAB < distanceAC)
//     Console.WriteLine($"Point B is closer to A. Distance: {distanceAB}");
// else
//     Console.WriteLine($"Point C is closer to A. Distance: {distanceAC}");

// If 22. Даны координаты точки, не лежащей на координатных осях OX и OY.
// Определить номер координатной четверти, в которой находится данная точка.
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// if (x > 0 && y > 0)
//     Console.WriteLine(1);
// else if (x < 0 && y > 0)
//     Console.WriteLine(2);
// else if (x < 0 && y < 0)
//     Console.WriteLine(3);
// else if (x > 0 && y < 0)
//     Console.WriteLine(4);

// If29. Дано целое число. Вывести его строку-описание вида «отрицательное четное число», «нулевое число», «положительное нечетное число» и т. д.
// Variant #1
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n == 0)
//     Console.Write("Нулевое число: ");
// else
// {
//     if (n > 0)
//         Console.Write("Положительное ");
//     else
//         Console.Write("Отрицательное ");
//     
//     if (n % 2 == 0)
//         Console.Write("четное число");
//     else
//         Console.Write("нечетное число");
// }

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

// If30. Дано целое число, лежащее в диапазоне 1–999.
// Вывести его строку описание вида «четное двузначное число», «нечетное трехзначное число» и т. д.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n % 2 == 0)
//     Console.Write("Четное ");
// else
//     Console.Write("Нечетное ");
//
// if (n > 0 && n < 10)
//     Console.Write("однозначное число");
// else if (n > 9 && n < 100)
//     Console.Write("двузначное число");
// else
//     Console.Write("трехзначное число");

