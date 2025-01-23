// Integer: 1-23, 30


// Integer 1. Дано расстояние L в сантиметрах. Используя операцию деления нацело,
// найти количество полных метров в нем (1 метр = 100 см).
// Console.Write("Enter L: ");
// int l = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Meters: {l / 100}");

// Integer 2. Дана масса M в килограммах. Используя операцию деления нацело,
// найти количество полных тонн в ней (1 тонна = 1000 кг).
// Console.Write("Enter M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Tones: {m / 1000}");

// Integer 3. Дан размер файла в байтах. Используя операцию деления нацело,
// найти количество полных килобайтов, которые занимает данный файл (1 килобайт = 1024 байта).
// Console.Write("Enter bytes: ");
// int bytes = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Kilobytes: {bytes / 1024}");

// Integer 4. Даны целые положительные числа A и B (A > B).
// На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений).
// Используя операцию деления нацело, найти количество отрезков B, размещенных на отрезке A.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Result: {a / b}");

// Integer 5. Даны целые положительные числа A и B (A > B).
// На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений).
// Используя операцию взятия остатка от деления нацело, найти длину незанятой части отрезка A.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Result: {a % b}");

// Integer 6. Дано двузначное число. Вывести вначале его левую цифру (десятки), а затем — его правую цифру (единицы).
// Для нахождения десятков использовать операцию деления нацело, для нахождения единиц — операцию взятия остатка от деления.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n / 10} {n % 10}");

// Integer 7. Дано двузначное число. Найти сумму и произведение его цифр.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Sum: {n / 10 + n % 10}");

// Integer 8. Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n % 10}{n / 10}");

// Integer 9. Дано трехзначное число. Используя одну операцию деления нацело, вывести первую цифру данного числа (сотни).
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n / 100);

// Integer 10. Дано трехзначное число. Вывести вначале его последнюю цифру (единицы), а затем — его среднюю цифру (десятки).
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n % 100 % 10);

// Integer 11. Дано трехзначное число. Найти сумму и произведение его цифр
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int n1 = n / 100; // first
// int n2 = n / 10 % 10; // second
// int n3 = n % 10; // third
// Console.WriteLine($"Sum: {n1 + n2 + n3}");
// Console.WriteLine($"Product: {n1 * n2 * n3}");

// Integer 12. Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n % 10}{n / 10 % 10}{n / 100}");

// Integer 13. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее справа. Вывести полученное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n / 10 % 10}{n % 10}{n / 100}");

// Integer 14. Дано трехзначное число. В нем зачеркнули первую справа цифру и приписали ее слева. Вывести полученное число.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n % 10}{n / 100}{n / 10 % 10}");

// Integer 15. Дано трехзначное число. Вывести число,
// полученное при перестановке цифр сотен и десятков исходного числа (например, 123 перейдет в 213).
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n / 10 % 10}{n / 100}{n % 10}");

// Integer 16. Дано трехзначное число. Вывести число,
// полученное при перестановке цифр десятков и единиц исходного числа (например, 123 перейдет в 132).
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n / 100}{n % 10}{n / 10 % 10}");

// Integer 17. Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка от деления,
// найти цифру, соответствующую разряду сотен в записи этого числа
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n / 100 % 10}");

// Integer 18. Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка от деления,
// найти цифру, соответствующую разряду тысяч в записи этого числа.
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n / 1000 % 10}");

// Integer 19. С начала суток прошло N секунд (N — целое). Найти количество полных минут, прошедших с начала суток
// Console.Write("Enter seconds: ");
// int seconds = int.Parse(Console.ReadLine()!);
// Console.WriteLine(seconds / 60);

// Integer20. С начала суток прошло N секунд (N — целое). Найти количество полных часов, прошедших с начала суток.
// Console.Write("Enter seconds: ");
// int seconds = int.Parse(Console.ReadLine()!);
// Console.WriteLine(seconds / 3600);

// Integer 21. С начала суток прошло N секунд (N — целое). Найти количество секунд, прошедших с начала последней минуты.
// Console.Write("Enter seconds: ");
// int seconds = int.Parse(Console.ReadLine()!);
// Console.WriteLine(seconds % 60);

// Integer 22. С начала суток прошло N секунд (N — целое). Найти количество секунд, прошедших с начала последнего часа.
// Console.Write("Enter seconds: ");
// int seconds = int.Parse(Console.ReadLine()!);
// Console.WriteLine(seconds % 3600);

// Integer 23. С начала суток прошло N секунд (N — целое). Найти количество полных минут, прошедших с начала последнего часа.
// Console.Write("Enter seconds: ");
// int seconds = int.Parse(Console.ReadLine()!);
// Console.WriteLine(seconds % 3600 / 60);

// Integer 30. Дан номер некоторого года (целое положительное число).
// Определить соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год.
// Console.Write("Enter year: ");
// int year = int.Parse(Console.ReadLine()!);
//Console.WriteLine((year - 1) / 100 + 1); // Variant #1
//Console.WriteLine((year + 99) / 100); // Variant #2