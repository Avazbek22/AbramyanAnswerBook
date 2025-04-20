// // Путь к сеньору: https://www.youtube.com/watch?v=1TvjgRJ34v8&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=14&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83
//
// namespace AbramyanAnswerBook
// {
//     public class Arrays
//     {
//         static Random rnd = new Random(DateTime.Now.Millisecond);
//
//         /// <summary>
//         /// Outputs all the elements of the array vertical or horizontal
//         /// </summary>
//         /// <param name="array"></param>
//         /// <param name="horizontalPrint"></param>
//         /// <typeparam name="T"></typeparam>
//         static void ShowArray<T>(T[] array, bool horizontalPrint = false) where T : struct
//         {
//             if (horizontalPrint)
//             {
//                 Console.WriteLine(string.Join(' ', array));
//             }
//             else
//             {
//                 for (int i = 0; i < array.Length; i++)
//                     Console.WriteLine($"[{i}] = {array[i]}");
//             }
//             
//             Console.WriteLine();
//         }
//
//         static int[] RandomFillArray(int length, int minValue, int maxValue)
//         {
//             int[] array = new int[length];
//             for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] = rnd.Next(minValue, maxValue);
//             }
//             return array;
//         }
//
//         static void Array9()
//         {
//             // Array 9. Дан целочисленный массив размера N.
//             // Вывести все содержащиеся в данном массиве четные числа в порядке убывания их индексов,
//             // а также их количество K.
//
//             Console.Write("Enter N: ");
//             int n = int.Parse(Console.ReadLine()!);
//             int[] array = new int[n];
//             // for (int i = 0; i < array.Length; i++)
//             // {
//             //     array[i] = rnd.Next(2, 11);
//             //     Console.WriteLine($"[{i}] = {array[i]}");
//             // }
//
//             for (int i = 0; i < array.Length; i++)
//             {
//                 Console.Write($"[{i}] = ");
//                 array[i] = int.Parse(Console.ReadLine()!);
//             }
//
//             Console.WriteLine("/////////////////////");
//             int evensCount = 0;
//             
//             for (int i = array.Length - 1; i >= 0; i--)
//             {
//                 if (array[i] % 2 == 0)
//                 {
//                     Console.WriteLine($"[{i}] = {array[i]}");
//                     evensCount++;
//                 }
//             }
//             Console.WriteLine($"Even numbers count: {evensCount}");
//         }
//         
//         public static void Main()
//         {
//             Array9();
//         }
//     }
// }