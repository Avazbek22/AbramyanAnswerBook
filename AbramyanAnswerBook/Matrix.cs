// public class Matrix
// {
//     private static Random rnd = new Random(DateTime.Now.Millisecond);
//
//     static void ShowMatrix<T>(T[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             Console.Write("[ ");
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]} ");
//             }
//
//             Console.WriteLine("]");
//         }
//     }
//
//     static void Matrix26()
//     {
//         // Matrix 26. Дана матрица размера M × N. Найти номер ее столбца с наименьшим произведением элементов и вывести данный номер,
//         // а также значение наименьшего произведения.
//         Console.Write("Enter M: ");
//         int m = int.Parse(Console.ReadLine()!);
//         Console.Write("Enter N: ");
//         int n = int.Parse(Console.ReadLine()!);
//         int[,] matrix = new int[m, n];
//         
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 matrix[i, j] = rnd.Next(1, 10);
//             }
//         }
//
//         ShowMatrix(matrix);
//
//         int minProduct = int.MaxValue;
//         int minProductColumnIndex = -1;
//
//         for (int j = 0; j < n; j++)
//         {
//             int product = 1;
//             for (int i = 0; i < m; i++) 
//             {
//                 product *= matrix[i, j];
//             }
//
//             if (product < minProduct)
//             {
//                 minProduct = product;
//                 minProductColumnIndex = j;
//             }
//         }
//
//         Console.WriteLine($"Column with the smallest product: {minProductColumnIndex} (Product = {minProduct})");
//     }
//
//     public static void Main()
//     {
//     }
// }