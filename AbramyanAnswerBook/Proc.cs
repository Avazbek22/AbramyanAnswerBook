// // Proc: 1-4, 6, 10-11, 21-24, 26,27 29-30, 34,36
//
// // Путь к сеньору: Что такое методы?  | https://www.youtube.com/watch?v=Hn39KfUzhPw&t=1s&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83
// // Путь к сеньору: Перегрузка методов | https://www.youtube.com/watch?v=HXjhH9WPOIQ&t=8s&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83
// // Путь к сеньору: Значимые и ссылочные типы данных | https://www.youtube.com/watch?v=-7QqyKix9cM&t=683s&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83
// // Путь к сеньору: Ref, Out, In | https://www.youtube.com/watch?v=WdJ2j5pmKe0&t=2s&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83
//
// // SimpleCode: C# ФУНКЦИИ И МЕТОДЫ | https://www.youtube.com/watch?v=Xk8vRnm6xtc&t=15s&ab_channel=%23SimpleCode
// // SimpleCode: ПЕРЕГРУЗКА МЕТОДОВ  | https://www.youtube.com/watch?v=zTwElCN9FzU&t=1s&ab_channel=%23SimpleCode
// // SimpleCode: ССЫЛОЧНЫЕ И ЗНАЧИМЫЕ ТИПЫ C# | https://www.youtube.com/watch?v=_RUluZNOwfY&t=570s&ab_channel=%23SimpleCode
// // SimpleCode: Ref | https://www.youtube.com/watch?v=H3gznh97TlQ&t=5s&ab_channel=%23SimpleCode
// // SimpleCode: Out | https://www.youtube.com/watch?v=R9i0XFWkFps&t=20s&ab_channel=%23SimpleCode
// // SimpleCode: Необязательные параметры | https://www.youtube.com/watch?v=W1RZ61lJDr4&t=45s&ab_channel=%23SimpleCode
// // SimpleCode: Именованные параметры | https://www.youtube.com/watch?v=4nPxbyd3CyY&ab_channel=%23SimpleCode
//
//
// // ЗАДАНИЯ:
// //
// // 1. Реализовать метод, аналогичный Math.Pow(), который возводит число в заданную степень.
// //
// // 2. Реализовать метод, вычисляющий факториал заданного числа.
// //
// // 3. Реализовать метод, возвращающий N-ное число последовательности Фибоначчи по заданному индексу.
// //
// // 4. Реализовать метод, определяющий индекс заданного числа в последовательности Фибоначчи по заданному значению.
// //
// // 5. Реализовать две версии метода FindFibonacciIndex:
// //      Первая — выбрасывает исключение при отсутствии числа в последовательности.
// //      Вторая — возвращает -1, если число не является элементом последовательности.
// //
// // 6. Реализовать метод, проверяющий, является ли заданное число степенью числа 4. (Метод должен возвращать логическое значение).
// //
// // 7. Реализовать метод, проверяющий, принадлежит ли заданное число последовательности Фибоначчи.
// //
// // 8. Реализовать метод, который возвращает количество чётных цифр в заданном числе.
// //
// // 9. Реализовать метод, проверяющий содержит ли заданное число в себе заданную цифру. (Метод должен возвращать логическое значение).
// //
// // 10. Реализовать метод, который возвращает сумму чисел от 1 до N.
//
// namespace AbramyanAnswerBook
// {
//     public class Proc
//     {
//         // 1. Реализовать метод, аналогичный Math.Pow(), который возводит число в заданную степень.
//         static int CalculatePower(int number, int power)
//         {
//             int result = 1;
//             for (int i = 1; i <= power; i++)
//             {
//                 result *= number;
//             }
//             return result;
//         }
//
//         // 2. Реализовать метод, вычисляющий факториал заданного числа.
//         static int CalculateFactorial(int n)
//         {
//             int factorial = 1;
//             for (int i = 1; i <= n; i++)
//             {
//                 factorial *= i;
//             }
//
//             return factorial;
//         }
//
//         // 3. Реализовать метод, возвращающий N-ное число последовательности Фибоначчи по заданному индексу.
//          static int GetFibonacciNumber(int index)
//          {
//              int f1 = 0, f2 = 1, f3 = 1;
//              for (int i = 2; i < index; i++)
//              {
//                  f3 = f1 + f2;
//                  f1 = f2;
//                  f2 = f3;
//              }
//              return f3;
//          }
//
//         // 4. Реализовать метод, определяющий индекс заданного числа в последовательности Фибоначчи по заданному значению.
//         static int GetFibonacciIndex(int number)
//         {
//             int index = 2;
//             int f1 = 0, f2 = 1, f3 = 1;
//             while (f3 < number)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//                 index++;
//             }
//
//             return index;
//         }
//
//         // Первая — выбрасывает исключение при отсутствии числа в последовательности.
//         static int FindFibonacciIndexWithException(int number)
//         {
//             int index = 2;
//             int f1 = 0, f2 = 1, f3 = 1;
//             while (f3 < number)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//                 index++;
//             }
//
//             if (f3 != number)
//                 throw new ArgumentException("The given number is not in the sequence of Fibonacci numbers.");
//
//             return index;
//         }
//
//         // Вторая — возвращает -1, если число не является элементом последовательности.
//         static int FindFibonacciIndexWithErrorCode(int number)
//         {
//             int index = 2;
//             int f1 = 0, f2 = 1, f3 = 1;
//             while (f3 < number)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//                 index++;
//             }
//
//             return (f3 != number) ? -1 : index;
//         }
//
//         // 6. Реализовать метод, проверяющий, является ли заданное число степенью числа 4. (Метод должен возвращать логическое значение).
//         static bool IsPowerOfFour(int number)
//         {
//             int power = 1;
//             while (power < number)
//             {
//                 power *= 4;
//             }
//             return power == number;
//         }
//
//         // 7. Реализовать метод, проверяющий, принадлежит ли заданное число последовательности Фибоначчи.
//         static bool IsFibonacciNumber(int number)
//         {
//             int f1 = 0, f2 = 1, f3 = 1;
//             while (f3 < number)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//             }
//
//             return f3 == number;
//         }
//
//         // 8. Реализовать метод, который возвращает количество чётных цифр в заданном числе.
//         static int GetCountOfEvenDigits(int number)
//         {
//             int count = 0;
//             while (number > 0)
//             {
//                 if (number % 2 == 0)
//                     count++;
//                 number /= 10;
//             }
//             return count;
//         }
//
//         // 9. Реализовать метод, проверяющий содержит ли заданное число в себе заданную цифру. (Метод должен возвращать логическое значение).
//         static bool NumberContainsDigit(int number, int digit)
//         {
//             while (number > 0)
//             {
//                 if (number % 10 == digit)
//                     return true;
//                 number /= 10;
//             }
//             return false;
//         }
//
//         // 10. Реализовать метод, который возвращает сумму чисел от 1 до N.
//         static int GetSumOfNumbers(int n)
//         {
//             int sum = 0;
//             for (int i = 1; i <= n; i++)
//             {
//                 sum += i;
//             }
//             return sum;
//         }
//
//
//         /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//
//         /// <summary>
//         /// Proc 1. Описать процедуру PowerA3(A, B), вычисляющую третью степень числа A и возвращающую ее в переменной B
//         /// (A — входной, B — выходной параметр; оба параметра являются вещественными).
//         /// </summary>
//         static void Proc1(int a,out int b)
//         {
//             b = a * a * a;
//         }
//
//         /// <summary>
//         /// Proc 2. Описать процедуру PowerA234(A, B, C, D), вычисляющую вторую, третью и четвертую степень числа A
//         /// и возвращающую эти степени соответственно в переменных B, C и D (A — входной, B, C, D — выходные параметры соответственно
//         /// </summary>
//         static void Proc2(int a, out int b, out int c, out int d)
//         {
//             b = a * a;
//             c = b * a;
//             d = c * a;
//         }
//
//         /// <summary>
//         /// Proc 3. Описать процедуру Mean(X, Y, AMean, GMean), вычисляющую среднее арифметическое AMean = (X+Y)/2
//         /// и среднее геометрическоеGMean =√X·Y двух положительных чисел X и Y (X и Y — входные, AMean и GMean — выходные параметры).
//         /// </summary>
//         static void Proc3(int x, int y, out int aMean, out double gMean)
//         {
//             aMean = (x + y) / 2;
//             gMean = Math.Sqrt(x * y);
//         }
//
//         /// <summary>
//         /// Proc 4. Описать процедуру TrianglePS(a, P, S), вычисляющую по стороне a равностороннего треугольника его периметр P = 3·a
//         /// и площадь S = a2·√3/4 (a — входной, P и S — выходные параметры;
//         /// </summary>
//         static void Proc4(int a, out int p, out double s)
//         {
//             p = 3 * a;
//             s = a * a * Math.Sqrt(3) / 4;
//         }
//
//         /// <summary>
//         /// Proc 5. Описать процедуру RectPS(x1, y1, x2, y2, P, S), вычисляющую периметр P и площадь S прямоугольника со сторонами,
//         /// параллельными осям координат, по координатам (x1, y1), (x2, y2) его противоположных вершин
//         /// (x1, y1, x2, y2 — входные, P и S — выходные параметры).
//         /// </summary>
//         static void Proc5(int x1, int y1, int x2, int y2, out int p, out double s)
//         {
//             int width = Math.Abs(x2 - x1);
//             int height = Math.Abs(y2 - y1);
//
//             p = 2 * (width + height);
//             s = width * height;
//         }
//
//         /// <summary>
//         /// Proc 6. Описать процедуру DigitCountSum(K, C, S), находящую количество C цифр целого положительного числа K,
//         /// а также их сумму S (K — входной, C и S — выходные параметры целого типа).
//         /// </summary>
//         static void Proc6(int k, out int c, out int s)
//         {
//             c = 0;
//             s = 0;
//             while (k > 0)
//             {
//                 c++;
//                 s += k % 10;
//                 k /= 10;
//             }
//         }
//
//         /// <summary>
//         /// Proc 10. Описать процедуру Swap(X, Y), меняющую содержимое переменных X и Y
//         /// (X и Y — вещественные параметры, являющиеся одновременно входными и выходными).
//         /// </summary>
//         static void Proc10(ref double x, ref double y)
//         {
//             double temp = x;
//             x = y;
//             y = temp;
//         }
//
//         static void Swap(ref double x, ref double y) => (x, y) = (y, x);
//
//         static void Swap<T>(T x, T y) => (x, y) = (y, x);
//
//
//         /// <summary>
//         /// Proc 11. Описать процедуру Minmax(X, Y), записывающую в переменную X минимальное из значений X и Y,
//         /// а в переменную Y — максимальное из этих значений (X и Y — вещественные параметры, являющиеся одновременно входными и выходными).
//         /// </summary>
//         static void Proc11(ref double x, ref double y)
//         {
//             if (x > y)
//                 x = y;
//             else
//                 y = x;
//         }
//
//         /// <summary>
//         /// Proc 12. Описать процедуру SortInc3(A, B, C), меняющую содержимое переменных A, B, C таким образом,
//         /// чтобы их значения оказались упорядоченными по возрастанию (A, B, C — вещественные параметры,
//         /// являющиеся одновременно входными и выходными).
//         /// </summary>
//         static void Proc12(ref double a, ref double b, ref double c)
//         {
//             if (a > b)
//                 Swap(ref a, ref b);
//             if (a > c)
//                 Swap(ref a, ref c);
//             if (b > c)
//                 Swap(ref b, ref c);
//         }
//
//         /// <summary>
//         /// Proc 21. Описать функцию SumRange(A, B) целого типа, находящую сумму всех целых чисел от A до B включительно (A и B — целые).
//         /// Если A > B, то функция возвращает 0.
//         /// </summary>
//         static int Proc21(int a, int b)
//         {
//             int sum = 0;
//             for (int i = a; i <= b; i++)
//             {
//                 sum += i;
//             }
//             return sum;
//         }
//
//         /// <summary>
//         /// Proc 22. Описать функцию Calc(A, B, Op) вещественного типа, выполняющую над ненулевыми вещественными числами
//         /// A и B одну из арифметических операций и возвращающую ее результат.
//         /// Вид операции определяется целым параметром Op: 1 — вычитание, 2 — умножение, 3 — деление, остальные значения — сложение.
//         /// </summary>
//         static double Proc22(double a, double b, int op)
//         {
//             switch (op)
//             {
//                 case 1: return a - b;
//                 case 2: return a * b;
//                 case 3: return a / b;
//                 default: return a + b;
//             }
//         }
//
//         /// <summary>
//         /// Proc 23. Описать функцию Quarter(x, y) целого типа, определяющую номер координатной четверти,
//         /// в которой находится точка с ненулевыми вещественными координатами (x, y).
//         /// </summary>
//         static int Proc23(int x, int y)
//         {
//             if (x > 0 && y > 0)
//                 return 1;
//             if (x < 0 && y > 0)
//                 return 2;
//             if (x < 0 && y < 0)
//                 return 3;
//             if (x > 0 && y < 0)
//                 return 4;
//
//             return -1;
//         }
//
//         // Proc 24. Описать функцию Even(K) логического типа, возвращающую TRUE, если целый параметр K является четным,
//         // и FALSE в противном случае.
//         static bool Proc24(int k) => k % 2 == 0;
//
//         /// <summary>
//         /// Proc 26. Описать функцию IsPower5(K) логического типа, возвращающую TRUE,
//         /// если целый параметр K (> 0) является степенью числа 5, и FALSE в противном случае.
//         /// </summary>
//         static bool Proc26(int k)
//         {
//             int power = 1;
//             while (power < k)
//             {
//                 power *= 5;
//             }
//             return power == k;
//         }
//
//         /// <summary>
//         /// Proc 27. Описать функцию IsPowerN(K, N) логического типа, возвращающую TRUE,
//         /// если целый параметр K (> 0) является степенью числа N (> 1), и FALSE в противном случае.
//         /// </summary>
//         static bool Proc27(int k, int n)
//         {
//             int power = 1;
//             while (power < k)
//             {
//                 power *= n;
//             }
//             return power == k;
//         }
//
//         /// <summary>
//         /// Proc 29. Описать функцию DigitCount(K) целого типа, находящую количество цифр целого положительного числа K.
//         /// </summary>
//         static int Proc29(int k)
//         {
//             int count = 0;
//             while (k > 0)
//             {
//                 count++;
//                 k /= 10;
//             }
//             return count;
//         }
//
//         /// <summary>
//         /// Proc 30. Описать функцию DigitN(K, N) целого типа, возвращающую N-ю цифру целого положительного числа K
//         /// (цифры в числе нумеруются справа налево). Если количество цифр в числе K меньше N, то функция возвращает −1
//         /// </summary>
//         static int Proc30(int k, int n)
//         {
//             int count = 0;
//             while (k > 0)
//             {
//                 if (count == n)
//                     return k % 10;
//                 count++;
//                 k /= 10;
//             }
//             return -1;
//         }
//
//         /// <summary>
//         /// Proc 31. Описать функцию IsPalindrom(K), возвращающую TRUE, если целый параметр K (> 0) является палиндромом
//         /// (то есть его запись читается одинаково слева направо и справа налево), и FALSE в противном случае.
//         /// При описании функции можно использовать функции DigitCount и DigitN из заданий Proc29 и Proc30.
//         /// </summary>
//         static bool Proc31(int k)
//         {
//             int length = Proc29(k);
//             for (int i = 1; i <= length / 2; i++)
//             {
//                 if (Proc30(k, i) != Proc30(k, length - i + 1))
//                     return false;
//             }
//             return true;
//         }
//
//         /// <summary>
//         /// Proc 34. Описать функцию Fact(N) вещественного типа, вычисляющую значение факториала N! = 1·2·. . .·N (N > 0 — параметр целого типа;
//         /// </summary>
//         static double Proc34(int n)
//         {
//             double result = 1;
//             for (int i = 1; i <= n; i++)
//             {
//                 result *= i;
//             }
//             return result;
//         }
//
//         /// <summary>
//         /// Proc 36. Описать функцию Fib(N) целого типа, вычисляющую N-й элемент последовательности чисел Фибоначчи FK,
//         /// которая описывается следующими формулами: F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, .
//         /// </summary>
//         static int Proc36(int n)
//         {
//             int f1 = 0, f2 = 1, f3 = 1;
//             for (int i = 2; i < n; i++)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//             }
//             return f3;
//         }
//
//         /// <summary>
//         /// Proc 52. Описать функцию IsLeapYear(Y) логического типа, которая возвращает TRUE,
//         /// если год Y (целое положительное число) является високосным, и FALSE в противном случае.
//         /// </summary>
//         static bool Proc52(int y)
//         {
//             return y % 4 == 0 && y % 100 != 0 || y % 400 == 0;
//         }
//
//         public static void Main()
//         {
//             Console.WriteLine(Proc36(8));
//         }
//     }
// }
//
