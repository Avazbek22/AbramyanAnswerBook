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

        static void Array9()
        {
            // Array 9. Дан целочисленный массив размера N.
            // Вывести все содержащиеся в данном массиве четные числа в порядке убывания их индексов,
            // а также их количество K.

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 11);
                Console.WriteLine($"[{i}] = {array[i]}");
            }

            Console.WriteLine("/////////////////////");
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
            Array42();
        }
    }
}