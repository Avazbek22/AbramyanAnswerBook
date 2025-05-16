// // Proc: 1-6, 10-15, 21-24, 26,27 29-31, 34,36,52
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
//
// // 1. Реализовать метод, аналогичный Math.Pow(), который возводит число в заданную степень.
//
// // 2. Реализовать метод, вычисляющий факториал заданного числа.
//
// // 3. Реализовать метод, возвращающий N-ное число последовательности Фибоначчи по заданному индексу.
//
// // 4. Реализовать метод, определяющий индекс заданного числа в последовательности Фибоначчи по заданному значению.
//
// // 5. Реализовать две версии метода FindFibonacciIndex:
// //      Первая — выбрасывает исключение при отсутствии числа в последовательности.
// //      Вторая — возвращает -1, если число не является элементом последовательности.
//
// // 6. Реализовать метод, проверяющий, является ли заданное число степенью числа 4. (Метод должен возвращать логическое значение).
//
// // 7. Реализовать метод, проверяющий, принадлежит ли заданное число последовательности Фибоначчи.
//
// // 8. Реализовать метод, который возвращает количество чётных цифр в заданном числе.
//
// // 9. Реализовать метод, проверяющий содержит ли заданное число в себе заданную цифру. (Метод должен возвращать логическое значение).
//
// // 10. Реализовать метод, который возвращает сумму чисел от 1 до N.
//
// namespace AbramyanAnswerBook
// {
//     public class Proc
//     {
//         public static void Main()
//         {
//             Console.WriteLine(IsPowerOfFour(24));
//         }
//
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
//         static int GetFibonacciNumber(int index)
//         {
//             int f1 = 0, f2 = 1, f3 = 1;
//             for (int i = 0; i < index; i++)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//             }
//             return f3;
//         }
//
//         static int GetFibonacciIndex(int number)
//         {
//             int index = 0;
//             int f1 = 0, f2 = 1, f3 = 1;
//             while (f3 <= number)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//                 index++;
//             }
//             return index;
//         }
//
//         static int FindFibonacciIndexWithException(int number)
//         {
//             int index = 0;
//             int f1 = 0, f2 = 1, f3 = 1;
//             while (f3 <= number)
//             {
//                 f3 = f1 + f2;
//                 f1 = f2;
//                 f2 = f3;
//                 index++;
//             }
//             return index;
//         }
//
//         static bool IsPowerOfFour(int number)
//         {
//             int power = 1;
//             while (power < number)
//             {
//                 power *= 4;
//             }
//             return power == number;
//         }
//     }
// }
//
