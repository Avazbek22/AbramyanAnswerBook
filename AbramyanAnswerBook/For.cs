//For: 1-20, 33, 36-40


// For 1. Даны целые числа K и N (N > 0). Вывести N раз число K.
// Console.Write("Enter K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(k);
// }  


// For 2. Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа,
// расположенные между A и B (включая сами числа A и B), а также количество N этих чисел.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = a; i <= b; i++)
// {
//     Console.WriteLine(i);
// }
//
// Console.WriteLine($"Count: {b - a + 1}");


// For 3. Даны два целых числа A и B (A < B). Вывести в порядке убывания все целые числа,
// расположенные между A и B (не включая числа A и B), а также количество N этих чисел.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = b; i >= a; i--)
// {
//     Console.WriteLine(i);
// }
//
// Console.WriteLine($"Count: {b - a + 1}");


// For 4. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1, 2, . . . , 10 кг конфет
// Console.Write("Enter price for candies: ");
// decimal price = decimal.Parse(Console.ReadLine()!);
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"Price for {i} kg = {price * i}");
// }


// For 5. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1, 0.2, . . . , 1 кг конфет.
// Console.Write("Enter price for candies: ");
// decimal price = decimal.Parse(Console.ReadLine()!);
// for (decimal i = 0.1m; i <= 1; i += 0.1m)
// {
//     Console.WriteLine($"Price for {i} kg = {price * i}");
// }

// For 5. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1, 0.2, . . . , 1 кг конфет.
// Variant #2
// Console.Write("Enter price for candies: ");
// decimal price = decimal.Parse(Console.ReadLine()!);
// for (decimal i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"Price for {i * 0.1m} kg = {price * i * 0.1m}");
// }