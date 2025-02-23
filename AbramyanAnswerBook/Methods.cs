// public class Program
// {
//     private static Random rnd = new Random(DateTime.Now.Millisecond);
//
//     public static void Main()
//     {
//         int[] array = Enumerable.Range(0, 10).ToArray();
//         double[] array2 = { 1, 2, 3, 4, 5, 34, 33, 3, 3, 4 };
//         decimal[] array3 = { 1, 2, 3, 4, 5, 34, };
//         ShowArray(array);
//         ShowArray(array2);
//         ShowArray(array3);
//     }
//
//     public static void ShowArray<T>(T[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             Console.WriteLine($"[{i}] = {array[i]}");
//     }
//
//     public static bool IsFibonacciNumber(int number)
//     {
//         int f1 = 0, f2 = 1, f3 = 1;
//         while (f3 < number)
//         {
//             f1 = f2;
//             f2 = f3;
//             f3 = f1 + f2;
//         }
//         
//         return f3 == number;
//     }
//
//     static (int max, int min) GetMaxAndMin(int a, int b)
//     {
//         if (a > b)
//             return (a, b);
//
//         return (b, a);
//     }
//
//     /// <summary>
//     /// returns the sum of two integers a and b.
//     /// </summary>
//     /// <param name="a">first number</param>
//     /// <param name="b">second number</param>
//     /// <returns>sum of two given numbers</returns>
//     public static int Sum(int a, int b)
//     {
//         return a + b;
//     }
//
//     public static void SayHello()
//     {
//         Console.WriteLine("Hello");
//     }
//
//
//     public static int Sum(int a, int b, int c)
//     {
//         return a + b + c;
//     }
// }