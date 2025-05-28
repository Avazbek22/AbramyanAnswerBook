// Путь к сеньору: https://www.youtube.com/watch?v=1TvjgRJ34v8&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=14&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83

namespace AbramyanAnswerBook
{
    public class Arrays
    {
        static Random rnd = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// Outputs all the elements of the array vertical or horizontal
        /// </summary>
        /// <param name="array"></param>
        /// <param name="horizontalPrint"></param>
        /// <typeparam name="T"></typeparam>
        static void ShowArray<T>(T[] array, bool horizontalPrint = false) where T : struct
        {
            if (horizontalPrint)
            {
                Console.WriteLine(string.Join(' ', array));
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                    Console.WriteLine($"[{i}] = {array[i]}");
            }
            
            Console.WriteLine();
        }

        static int[] RandomFillArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
            return array;
        }
        
        static int[] RandomFillArray(int length, int maxValue)
        {
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(maxValue);
            }
            return array;
        }
        
        static double[] RandomFillArray(int length)
        {
            double[] array = new double[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble();
            }
            return array;
        }

        static int[] GenerateNaturalArray(int count) => Enumerable.Range(1, count).ToArray();

        static void Array1()
        {
            // Array 1. Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N,
            // содержащий N первых положительных нечетных чисел: 1, 3, 5,...
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            for (int i = 0, j = 1; i < array.Length; i++, j += 2)
            {
                array[i] = j;
                Console.WriteLine($"[{i}] = {array[i]}");
            }
        }

        static void Array1_2()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
                array[i] = 1 + i * 2;
            
            ShowArray(array);
        }

        static void Array2()
        {
            // Array 2. Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N,
            // содержащий степени двойки от первой до N-й: 2, 4, 8, 16 
            
            // Author Vladislav Zvantsev.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            array[0] = 2;
            for (int i = 1; i < array.Length; i++)
                array[i] = array[i - 1] * 2;
            
            ShowArray(array);
        }

        static void Array3()
        {
            // Array3. Дано целое число N (> 1), а также первый член A и разность D арифметической прогрессии.
            // Сформировать и вывести массив размера N, содержащий N первых членов данной прогрессии: A, A + D, A + 2·D, A + 3·D,
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter D: ");
            int d = int.Parse(Console.ReadLine()!);
            array[0] = a;
            for (int i = 1; i < array.Length; i++)
                array[i] = array[i - 1] + d;
            
            ShowArray(array);
            
        }

        static void Array4()
        {
            // Array4. Дано целое число N (> 1), а также первый член A и знаменатель D геометрической прогрессии.
            // Сформировать и вывести массив размера N, содержащий N первых членов данной прогрессии: A, A·D, A·D^2, A·D^3. . . .
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter D: ");
            int d = int.Parse(Console.ReadLine()!);
            array[0] = a;
            for (int i = 1; i < array.Length; i++)
                array[i] = array[i - 1] * d;
            
            ShowArray(array);
        }

        static void Array5()
        {
            // Array5. Дано целое число N (> 2). Сформировать и вывести целочисленный массив размера N,
            // содержащий N первых элементов последовательности чисел Фибоначчи FK: F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, . . . .
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < array.Length; i++)
                array[i] = array[i - 1] + array[i - 2];
            
            ShowArray(array);
        }

        static void Array6()
        {
            // Array 6. Даны целые числа N (> 2), A и B. Сформировать и вывести целочисленный массив размера N,
            // первый элемент которого равен A, второй равен B, а каждый последующий элемент равен сумме всех предыдущих.
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            array[0] = a;
            array[1] = b;
            for (int i = 2; i < array.Length; i++)
                array[i] = array[i - 1] + array[i - 2];
            
            ShowArray(array);
        }

        static void Array6_2()
        {
            // Author Semen Vaysman
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine()!);
            int[] array = new int[10];
            array[0] = a;
            array[1] = b;
            int sum = a + b;
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = sum;
                sum += array[i];
            }
        }

        static void Array7()
        {
            // Array 7. Дан массив размера N. Вывести его элементы в обратном порядке
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine($"[{i}] = {array[i]}");
            }

            Console.WriteLine("/////////////////////////");

            for (int i = array.Length - 1; i >= 0; i--)
                Console.WriteLine($"[{i}] = {array[i]}");
        }

        static void Array8()
        {
            // Array 8. Дан целочисленный массив размера N.
            // Вывести все содержащиеся в данном массиве нечетные числа в порядке возрастания их индексов, а также их количество K.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            Console.WriteLine("Odd numbers:");
            int oddsCount = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"[{i}] = {array[i]}");
                    oddsCount++;
                }
            }
            
            Console.WriteLine($"Odd numbers count: {oddsCount}");
        }
        
        static void Array9()
        {
            // Array 9. Дан целочисленный массив размера N.
            // Вывести все содержащиеся в данном массиве четные числа в порядке убывания их индексов,
            // а также их количество K.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            Console.WriteLine("Even numbers:");
            int evensCount = 0;
            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"[{i}] = {array[i]}");
                    evensCount++;
                }
            }
            Console.WriteLine($"Even numbers count: {evensCount}");
        }

        static void Array10()
        {
            // Array 10. Дан целочисленный массив размера N. Вывести вначале все содержащиеся в данном массиве
            // четные числа в порядке возрастания их индексов, а затем — все нечетные числа в порядке убывания их индексов.

            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);
            
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    Console.WriteLine($"[{i}] = {array[i]}");
            }
            
            Console.WriteLine("Odd numbers:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                    Console.WriteLine($"[{i}] = {array[i]}");
            }
        }

        static void Array11()
        {
            // Array 11. Дан массив A размера N и целое число K (1 ≤ K ≤ N).
            // Вывести элементы массива с порядковыми номерами, кратными K: AK, A2·K, A3·K, . .
            // Условный оператор не использовать.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            for (int i = k; i < array.Length; i += k)
                Console.WriteLine($"[{i}] = {array[i]}");
        }

        static void Array12()
        {
            // Array 12. Дан массив A размера N (N — четное число).
            // Вывести его элементы с четными номерами в порядке возрастания номеров: A2, A4, A6, . . ., AN .
            // Условный оператор не использовать.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);
            
            for (int i = 2; i < array.Length; i += 2)
                Console.WriteLine($"[{i}] = {array[i]}");
        }

        static void Array13()
        {
            // Array 13. Дан массив A размера N (N — нечетное число).
            // Вывести его элементы с нечетными номерами в порядке убывания номеров: AN , AN−2, AN−4, . . .,A1.
            // Условный оператор не использовать.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);
            
            for (int i = array.Length - 1; i >= 2; i -= 2)
                Console.WriteLine($"[{i}] = {array[i]}");
        }

        static void Array14()
        {
            // Array 14. Дан массив A размера N. Вывести вначале его элементы с четными номерами (в порядке возрастания номеров),
            // а затем — элементы с нечетными номерами (также в порядке возрастания номеров): A2, A4, A6, . . ., A1, A3, A5, . . . .
            //Условный оператор не использовать.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);
            
            Console.WriteLine("Even indexes:");
            
            for (int i = 2; i < array.Length; i += 2)
                Console.WriteLine($"[{i}] = {array[i]}");

            Console.WriteLine("Odd indexes:");
            
            for (int i = 1; i < array.Length; i += 2)
                Console.WriteLine($"[{i}] = {array[i]}");
        }

        static void Array15()
        {
            // Array 15. Дан массив A размера N. Вывести вначале его элементы с нечетными номерами в порядке возрастания номеров,
            // а затем — элементы с четными номерами в порядке убывания номеров: A1, A3, A5, . . ., A6, A4, A2. Условный оператор не использовать.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);
            
            Console.WriteLine("Odd indexes:");
            
            for (int i = 1; i < array.Length; i += 2)
                Console.WriteLine($"[{i}] = {array[i]}");
            
            Console.WriteLine("Even indexes:");
            
            int start = (array.Length - 1) % 2 == 0 ? array.Length - 1 : array.Length - 2;
            
            for (int i = start; i >= 0; i -= 2)
                Console.WriteLine($"[{i}] = {array[i]}");
        }

        static void Array16()
        {
            // Array 16. Дан массив A размера N. Вывести его элементы в следующем порядке: A1, AN , A2, AN−1, A3, AN−2, . . . .
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            Console.WriteLine("Reordered elements:");
            int half = n / 2;

            for (int i = 0; i < half; i++)
            {
                Console.WriteLine($"[{i}] = {array[i]}");
                Console.WriteLine($"[{n - 1 - i}] = {array[n - 1 - i]}");
            }

            // Если нечётное — центральный элемент ещё не выведен
            int middleIndex = half * 2 == n ? -1 : half;
            Console.WriteLine($"{(middleIndex + 1 > 0 ? $"[{middleIndex}] = {array[middleIndex]}" : "")}");
        }
        
        static void Array17()
        {
            
        }
        

        static void Array40()
        {
            // Array 40. Дано число R и массив A размера N. Найти элемент массива, который наиболее близок к числу R
            // (то есть такой элемент AK, для которого величина |AK − R| является минимальной).

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter R: ");
            int r = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
                Console.WriteLine($"[{i}] = {array[i]}");
            }
            int closestIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - r) < Math.Abs(array[closestIndex] - r))
                    closestIndex = i;
            }

            Console.WriteLine($"Result: {array[closestIndex]}");
        }
        
        static void Array42()
        {
            // Array42. Дано число R и массив размера N. Найти два соседних элемента массива,
            // сумма которых наиболее близка к числу R, и вывести эти элементы
            // в порядке возрастания их индексов (определение наиболее близких чисел дано в задании Array40).
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter R: ");
            int r = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
                Console.WriteLine($"[{i}] = {array[i]}");
            }
            Console.WriteLine("---------------------------");
            int firstValue = 0;
            int secondValue = 0;
            int sum = 0;
            int closestSum = int.MaxValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                sum = array[i] + array[i + 1];
                if (Math.Abs(sum - r) < Math.Abs(closestSum - r))
                {
                    closestSum = sum;
                    firstValue = array[i ];
                    secondValue = array[i + 1];
                }
            }
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
        }
        
        public static void Main()
        {
            Array15();
        }
    }
}