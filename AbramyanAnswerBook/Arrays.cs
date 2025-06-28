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
            for (int i = 0; i < array.Length; i++)
                array[i] = a + i * d;
            
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
            // Array17. Дан массив A размера N. Вывести его элементы в следующем порядке:
            // A1, A2, AN , AN−1, A3, A4, AN−2, AN−3, . . . .
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);
            
            int left = 0, right = n - 1;
            for (int k = 0; k < array.Length; k++)
            {
                if ((k / 2) % 2 == 0)
                    Console.Write(array[left++] + " ");  // два раза подряд с начала
                else
                    Console.Write(array[right--] + " ");  // два раза подряд с конца
            }
        }

        static void Array18()
        {
            // Array 18. Дан массив A ненулевых целых чисел размера 10.
            // Вывести значение первого из тех его элементов AK, которые удовлетворяют неравенству AK < A10. Если таких элементов нет, то вывести 0.

            int[] array = RandomFillArray(10, -10,11);
            ShowArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[^1])
                {
                    Console.WriteLine($"Result: [{i}] = {array[i]}");
                    return;
                }
            }

            Console.WriteLine(0);
        }

        static void Array19()
        {
            // Array 19. Дан целочисленный массив A размера 10.
            // Вывести порядковый номер последнего из тех его элементов AK, которые удовлетворяют двойному неравенству A1 < AK < A10.
            // Если таких элементов нет, то вывести 0.
            
            int[] array = RandomFillArray(10, -10,11);
            ShowArray(array);

            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] < array[^1] && array[i] > array[0])
                {
                    Console.WriteLine($"Result: [{i}] = {array[i]}");
                    return;
                }
            }
            Console.WriteLine(0);
        }

        static void Array20()
        {
            // Array 20. Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N).
            // Найти сумму элементов массива с номерами от K до L включительно.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine()!);
            Console.Write("Enter L: ");
            int l = int.Parse(Console.ReadLine()!);
            
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            int sum = 0;
            for (int i = k; i <= l; i++)
                sum += array[i];

            Console.WriteLine($"Sum: {sum}");
        }

        static void Array21()
        {
            // Array 21. Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N).
            // Найти среднее арифметическое элементов массива с номерами от K до L включительно.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine()!);
            Console.Write("Enter L: ");
            int l = int.Parse(Console.ReadLine()!);
            
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            int sum = 0;
            for (int i = k; i <= l; i++)
                sum += array[i];

            Console.WriteLine($"Average: {sum / Math.Abs(l - k)}");
        }

        static void Array22()
        {
            // Array 22. Дан массив размера N и целые числа K и L (1 < K ≤ L ≤ N).
            // Найти сумму всех элементов массива, кроме элементов с номерами от K до L включительно.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine()!);
            Console.Write("Enter L: ");
            int l = int.Parse(Console.ReadLine()!);
            
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            int sum = 0;
            for(int i = 0; i < k; i++)
                sum += array[i];
            
            for(int i = l + 1; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine($"Sum: {sum}");
        }

        static void Array23()
        {
            // Array 23. Дан массив размера N и целые числа K и L (1 < K ≤ L ≤ N).
            // Найти среднее арифметическое всех элементов массива, кроме элементов с номерами от K до L включительно.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine()!);
            Console.Write("Enter L: ");
            int l = int.Parse(Console.ReadLine()!);
            
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);

            int sum = 0;
            for(int i = 0; i < k; i++)
                sum += array[i];
            
            for(int i = l + 1; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine($"Average: {sum / Math.Abs(l - k)}");
        }

        static void Array24()
        {
            // Array 24. Дан целочисленный массив размера N, не содержащий одинаковых чисел.
            // Проверить, образуют ли его элементы арифметическую прогрессию.
            // Если образуют, то вывести разность прогрессии, если нет — вывести 0.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 11);
            ShowArray(array);
            
            int diff = array[1] - array[0]; 
            bool isProgression = true;

            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] != diff)
                {
                    isProgression = false;
                    break;
                }
            }

            Console.WriteLine(isProgression ? diff : 0);
        }

        static void Array25()
        {
            // Array 25. Дан массив ненулевых целых чисел размера N.
            // Проверить, образуют ли его элементы геометрическую прогрессию.
            // Если образуют, то вывести знаменатель прогрессии, если нет — вывести 0.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 11);
            
            int ratio = array[1] / array[0];

            for (int i = 1; i < n; i++)
            {
                if (array[i] != array[i - 1] * ratio)
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine($"Result: {ratio}");
        }

        static void Array26()
        {
            // Array 26. Дан целочисленный массив размера N. Проверить, чередуются ли в нем четные и нечетные числа.
            // Если чередуются, то вывести 0, если нет, то вывести порядковый номер первого элемента, нарушающего закономерность.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 11);
            ShowArray(array);
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 == array[i + 1] % 2)
                {
                    Console.WriteLine($"Wrong item: [{++i}] =  {array[i]}");
                    return;
                }
            }
            Console.WriteLine("0");
        }

        static void Array27()
        {
            // Array 27. Дан массив ненулевых целых чисел размера N.
            // Проверить, чередуются ли в нем положительные и отрицательные числа.
            // Если чередуются, то вывести 0, если нет, то вывести порядковый номер первого элемента, нарушающего закономерность
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, -10, 11);
            ShowArray(array);
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] * array[i + 1] > 0)
                {
                    Console.WriteLine($"Wrong item: [{++i}] =  {array[i]}");
                    return;
                }
            }

            Console.WriteLine("0");
        }
        
        static void Array28()
        {
            // Array 28. Дан массив A размера N.
            // Найти минимальный элемент из его элементов с четными номерами: A2, A4, A6,. . .
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array); 
            
            int minValue = array[0];
            for (int i = 2; i < array.Length; i += 2) 
            {
                if (array[i] < minValue)
                    minValue = array[i];
            }
            Console.WriteLine($"Min value: {minValue}");
        }

        static void Array29()
        {
            // Array 29. Дан массив A размера N.
            // Найти максимальный элемент из его элементов с нечетными номерами: A1, A3, A5, . . . .
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);
            
            int maxValue = array[1];
            for (int i = 3; i < array.Length; i += 2) 
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            Console.WriteLine($"Max value: {maxValue}");
        }

        static void Array30()
        {
            // Array 30. Дан массив размера N. Найти номера тех элементов массива,
            // которые больше своего правого соседа, и количество таких элементов.
            // Найденные номера выводить в порядке их возрастания.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);

            int count = 0;
            Console.WriteLine("Result:");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine($"[{i}] =  {array[i]}");
                    count++;
                }
            }

            Console.WriteLine($"Count: {count}");
        }

        static void Array31()
        {
            // Array 31. Дан массив размера N. Найти номера тех элементов массива,
            // которые больше своего левого соседа, и количество таких элементов.
            // Найденные номера выводить в порядке их убывания.
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);

            int count = 0;
            Console.WriteLine("Result:");
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > array[i - 1])
                {
                    Console.WriteLine($"[{i}] =  {array[i]}");
                    count++;
                }
            }
            Console.WriteLine($"Count: {count}");
        }

        static void Array32()
        {
            // Array 32. Дан массив размера N. Найти номер его первого локального минимума
            // (локальный минимум — это элемент, который меньше любого из своих соседей).

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    Console.WriteLine($"First local min is: [{i}] =  {array[i]}");
                    break;
                }
            }
        }

        static void Array33()
        {
            // Array 33. Дан массив размера N. Найти номер его последнего локального максимума
            // (локальный максимум — это элемент, который больше любого из своих соседей).
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);
            
            for (int i = array.Length - 2; i > 0; i--)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.WriteLine($"Last local max is: [{i}] =  {array[i]}");
                    break;
                }
            }
        }

        static void Array34()
        {
            // Array34. Дан массив размера N. Найти максимальный из его локальных минимумов
            // (определение локального минимума дано в задании Array32).
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);

            int maxLocalMin = int.MinValue;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1] && array[i] > maxLocalMin)
                    maxLocalMin = array[i];
            }

            Console.WriteLine($"Max local min value is: {maxLocalMin}");
        }

        static void Array35()
        {
            // Array 35. Дан массив размера N. Найти минимальный из его локальных максимумов
            // (определение локального максимума дано в задании Array 33).
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);
            
            int minLocalMax = int.MaxValue;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1] && array[i] < minLocalMax)
                    minLocalMax = array[i];
            }

            Console.WriteLine($"Min local max value is: {minLocalMax}");
        }

        static void Array36()
        {
            // Array 36. Дан массив размера N. Найти максимальный из его элементов, не являющихся ни локальным минимумом,
            // ни локальным максимумом (определения локального минимума и локального максимума даны в заданиях Array32 и Array33).
            // Если таких элементов в массиве нет, то вывести 0.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = RandomFillArray(n, 21);
            ShowArray(array);
            
            int maxNotLocal = int.MinValue;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (IsNotLocalMinAndNotLocalMax(i) && array[i] > maxNotLocal)
                    maxNotLocal = array[i];
            }

            Console.WriteLine(maxNotLocal != int.MinValue ? $"Max not local min/max = {maxNotLocal}" : "0");

            bool IsNotLocalMinAndNotLocalMax(int index)
            {
                return !(array[index] < array[index - 1] && array[index] < array[index + 1]) &&
                       !(array[index] > array[index - 1] && array[index] > array[index + 1]);
            }
        }

        static void Array37()
        {
            // Array 37. Дан массив размера N. Найти количество участков, на которых его элементы монотонно возрастают
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
        
        static void Array86()
        {
            // Array86. Дан массив A размера N и целое число K (1 ≤ K ≤ 4, K < N).
            // Осуществить циклический сдвиг элементов массива влево на K позиций
            // (при этом AN перейдет в AN−K, AN−1 — в AN−K−1, . . ., A1 — в AN−K+1).
            // Допускается использовать вспомогательный массив из 4 элементов.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine()!);
            int[] array = GenerateNaturalArray(n);
            ShowArray(array);
            
            int[] tempArray = new int[k];
            for (int i = 0, j = 0; i < k; i++)
                tempArray[j++] = array[i];

            for (int i = 0; i < array.Length - k; i++)
                array[i] = array[i + k];

            for (int i = array.Length - k, j = 0; i < array.Length; i++)
                array[i] = tempArray[j++];

            ShowArray(array);
        }
        
        static void Array89()
        {
            // Array89. Дан массив размера N, все элементы которого, кроме одного,
            // упорядочены по убыванию. Переместить нарушающий элемент на верное место.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}] = ");
                array[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("---------------------------");

            // 1) ищем первый индекс, где очередной элемент оказался больше предыдущего
            int wrongIndex = -1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    wrongIndex = i;
                    break;
                }
            }

            if (wrongIndex == -1)  // массив уже упорядочен
            {
                Console.WriteLine("Элемент, нарушающий убывание, не найден.");
                return;
            }
            
            if (wrongIndex < array.Length - 1 && array[wrongIndex] < array[wrongIndex + 1])
            {
                // Сдвиг вправо
                for (int i = wrongIndex; i < array.Length - 1 && array[i] < array[i + 1]; i++)
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }
            else
            {
                // Сдвиг влево
                for (int j = wrongIndex; j > 0 && array[j] > array[j - 1]; j--)
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
            }

            ShowArray(array);
        }

        
        public static void Main()
        {
            Array89();
        }
    }
}