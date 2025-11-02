// IT-Life Базовый синтаксис: https://youtu.be/G2f6-6pNaxU
// IT-Life Переменные: https://youtu.be/KUu8nTq0J3A
// IT-Life Типы данных: https://youtu.be/Mnj-FQS4XTE
// IT-Life var & object: https://youtu.be/8ZiuvHKCKcE

// Begin: 1-12, 16, 20, 22-24, 31-34

// Begin 1. Дана сторона квадрата a. Найти его периметр P = 4·a.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Perimeter: {a * 4}");

// Begin 2. Дана сторона квадрата a. Найти его площадь S = a^2
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Area: {a * a}");

//Begin 3. Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Area: {a * b}");
// Console.WriteLine($"Perimeter: {2 * (a + b)}");

// Begin 4. Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.
// Console.Write("Enter D: ");
// int d = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Length: {d * 3.14}");

// Begin 5. Дана длина ребра куба a. Найти объем куба V = a^3 и площадь его поверхности S = 6·a^2
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Volume: {a * a * a}");
// Console.WriteLine($"Surface area: {6 * a * a}");

// Begin 6. Даны длины ребер a, b, c прямоугольного параллелепипеда.
// Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Volume: {a * b * c}");
// Console.WriteLine($"Surface area: {2 * (a * b + b * c + a * c)}");

// Begin 7. Найти длину окружности L и площадь круга S заданного радиуса R: L = 2·π·R, S = π·R^2 В качестве значения π использовать 3.14.
// Console.Write("Enter R: ");
// int r = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Length: {2 * 3.14 * r}");
// Console.WriteLine($"Area: {3.14 * r * r}");

// Begin 8. Даны два числа a и b. Найти их среднее арифметическое: (a + b) / 2.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Average: {(a + b) / 2}");

// Begin 9. Даны два неотрицательных числа a и b.
// Найти их среднее геометрическое, то есть квадратный корень из их произведения: √a·b.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Square of root: {Math.Sqrt(a * b)}");

// Begin 10. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// int a2 = a * a, b2 = b * b;
// Console.WriteLine($"Sum: {a2 + b2}");
// Console.WriteLine($"Product: {a2 * b2}");
// Console.WriteLine($"Difference: {Math.Abs(a2 - b2)}");
// Console.WriteLine($"Quotient: {a2 / b2}");

// Begin 12. Даны катеты прямоугольного треугольника a и b.
// Найти его гипотенузу c и периметр P: c = √a^2 + b^2 , P = a + b + c.
// Console.Write("Enter A: ");
// double a = double.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// double b = double.Parse(Console.ReadLine()!);
// double c = Math.Sqrt(a * a + b * b);
// Console.WriteLine($"Hypotenuse: {c}");
// Console.WriteLine($"Perimeter: {a + b + c}");

// Begin 16. Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: |x2 − x1|.
// Console.Write("Enter X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Distance: {Math.Abs(x2 - x1)}");

// Begin 20. Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2) на плоскости.
// Расстояние вычисляется по формуле q(x2 − x1)^2 + (y2 − y1)^2
// Console.Write("Enter X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// double result = Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2));
// Console.WriteLine($"Result: {result}");

// Begin 22. Поменять местами содержимое переменных A и B и вывести новые значения A и B.
// Вариант 1: Через дополнительную переменную
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// int copyA = a;
// a = b;
// b = copyA;
// Console.WriteLine($"A: {a}");
// Console.WriteLine($"B: {b}");

// Begin 22. Поменять местами содержимое переменных A и B и вывести новые значения A и B.
//Вариант 2: Через конструкцию языка (кортеж)
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// (a, b) = (b, a);
// Console.WriteLine($"A: {a}");
// Console.WriteLine($"B: {b}");

// Begin 23. Даны переменные A, B, C. Изменить их значения,
// переместив содержимое A в B, B — в C, C — в A, и вывести новые значения переменных A, B, C.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// int copyB = b;
// b = a;
// a = c;
// c = copyB;
// Console.WriteLine($"A: {a}");
// Console.WriteLine($"B: {b}");
// Console.WriteLine($"C: {c}");

// Begin 24. Даны переменные A, B, C. Изменить их значения,
// переместив содержимое A в C, C — в B, B — в A, и вывести новые значения переменных A, B, C.
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// int copyC = c;
// c = a;
// a = b;
// b = copyC;
// Console.WriteLine($"A: {a}");
// Console.WriteLine($"B: {b}");
// Console.WriteLine($"C: {c}");

// Begin 31. Дано значение температуры T в градусах Фаренгейта.
// Определить значение этой же температуры в градусах Цельсия.
// Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением: TC = (TF − 32)·5/9.
// Console.Write("Enter TF: ");
// int tf = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Temperature in celsius: {(tf - 32) * 5 / 9}");

// Begin 32. Дано значение температуры T в градусах Цельсия.
// Определить значение этой же температуры в градусах Фаренгейта.
// Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением: TC = (TF − 32)·5/9.
// Console.Write("Enter TC: ");
// int tc = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Temperature in fahrenheit: {tc * 9 / 5 + 32}");

// Begin 33. Известно, что X кг конфет стоит A рублей. Определить, сколько стоит 1 кг и Y кг этих же конфет.
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// int priceForOneKg = a / x;
// Console.WriteLine($"Price for 1 kg: {priceForOneKg}");
// Console.WriteLine($"Price for {y} kg: {priceForOneKg * y}");

// Begin 34. Известно, что X кг шоколадных конфет стоит A рублей, а Y кг ирисок стоит B рублей.
// Определить, сколько стоит 1 кг шоколадных конфет, 1 кг ирисок, а также во сколько раз шоколадные конфеты дороже ирисок.
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// int chocolatePrice = a / x, toffeePrice = b / y;
// Console.WriteLine($"1kg chocolate costs: {chocolatePrice}");
// Console.WriteLine($"1kg toffee costs: {toffeePrice}");
// Console.WriteLine($"Chocolate {chocolatePrice / toffeePrice} times more expensive than toffee");