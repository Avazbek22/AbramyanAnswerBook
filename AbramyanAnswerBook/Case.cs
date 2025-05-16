// Case: 1,3,5,6,16-18

// Путь к сеньору: https://www.youtube.com/watch?v=BrrbnKqc0EE&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=10&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83


// Case 1. Дано целое число в диапазоне 1–7. Вывести строку — название дня недели,
// соответствующее данному числу (1 — «понедельник», 2 — «вторник» и т.д.)
// Console.Write("Введите день недели: ");
// int dayOfWeek = int.Parse(Console.ReadLine()!);
// switch (dayOfWeek)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота"); break;
//     case 7: Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Введите число в диапазоне 1-7!"); break;
// }





// Case 3. Дан номер месяца — целое число в диапазоне 1–12 (1 — январь, 2 — февраль и т.д.)
// Вывести название соответствующего времени года («зима», «весна», «лето», «осень»)
// Console.Write("Введите номер месяца: ");
// int month = int.Parse(Console.ReadLine()!);
// switch (month)
// {
//     case 12 or 1 or 2: Console.Write("Зима"); break;
//     case 3 or 4 or 5: Console.WriteLine("Весна"); break;
//     case 6 or 7 or 8: Console.WriteLine("Лето"); break;
//     case 9 or 10 or 11: Console.WriteLine("Осень"); break;
//     default: Console.WriteLine("Введите число в диапазоне 1-12!"); break;
// }





// Case 5. Арифметические действия над числами пронумерованы следующим образом: 1 — сложение, 2 — вычитание, 
// 3 — умножение, 4 — деление. Дан номер действия N (целое число в диапазоне 1–4)
// и вещественные числа A и B (В не равно 0). Выполнить над числами указанное действие и вывести результат.
// Console.Write("Введите номер действия: ");
// int action = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число A: ");
// double a = double.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// double b = double.Parse(Console.ReadLine()!);
// switch (action)
// {
//     case 1: Console.WriteLine(a + b); break;
//     case 2: Console.WriteLine(a - b); break;
//     case 3: Console.WriteLine(a * b); break;
//     case 4: Console.WriteLine(a / b); break;
//     default: Console.WriteLine("Введите номер действия в диапазоне 1-4!"); break;
// }





//Case 6. Единицы длины пронумерованы следующим образом: 1 — дециметр, 2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр.
//Дан номер единицы длины (целое число в диапазоне 1–5) и длина отрезка в этих единицах (вещественное число).
//Найти длину отрезка в метрах.
// Console.Write("Введите номер действия: ");
// int lengthInMeters = int.Parse(Console.ReadLine());
// Console.Write("Длинна отрезка: ");
// int unitsOfLength =  int.Parse(Console.ReadLine());
// switch (lengthInMeters)
// {
//     case 1: Console.WriteLine(unitsOfLength / 10); break;
//     case 2: Console.WriteLine(unitsOfLength * 1000); break;
//     case 3: Console.WriteLine(unitsOfLength); break;
//     case 4: Console.WriteLine(unitsOfLength / 1000); break;
//     case 5: Console.WriteLine(unitsOfLength / 100); break;
// }





// Case 16. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
// Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»,
// например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».
// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine()!);
// switch (age / 10) // first digit
// {
//     case 2: Console.Write("Двадцать "); break;
//     case 3: Console.Write("Тридцать "); break;
//     case 4: Console.Write("Сорок "); break;
//     case 5: Console.Write("Пятьдесят "); break;
//     case 6: Console.Write("Шестьдесят "); break;
//     default: Console.WriteLine("Вы превысили диапазон!"); return;
// }
//
// switch (age % 10) // second digit
// {
//     case 0: Console.WriteLine("лет"); break;
//     case 1: Console.WriteLine("один год"); break;
//     case 2: Console.WriteLine("два года"); break;
//     case 3: Console.WriteLine("три года"); break;
//     case 4: Console.WriteLine("четыре года"); break;
//     case 5: Console.WriteLine("пять лет"); break;
//     case 6: Console.WriteLine("шесть лет"); break;
//     case 7: Console.WriteLine("семь лет"); break;
//     case 8: Console.WriteLine("восемь лет"); break;
//     case 9: Console.WriteLine("девять лет"); break;
//     default: Console.WriteLine("Вы превысили диапазон!"); return;
// }





// Case 17. Дано целое число в диапазоне 10–40, определяющее количество учебных заданий по некоторой теме.
// Вывести строку-описание указанного количества заданий, обеспечив правильное согласование числа со словами «учебное задание»,
// например: 18 — «восемнадцать учебных заданий»,
// Console.Write("Введите номер задания: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n > 10 && n < 20) 
// {
//     switch (n)
//     {
//         case 11: Console.Write("Одиннадцать  "); break;
//         case 12: Console.Write("Двенадцать "); break;
//         case 13: Console.Write("Тринадцать "); break;
//         case 14: Console.Write("Четырнадцать "); break;
//         case 15: Console.Write("Пятнадцать "); break;
//         case 16: Console.Write("Шестнадцать "); break;
//         case 17: Console.Write("Семнадцать "); break;
//         case 18: Console.Write("Восемнадцать "); break;
//         case 19: Console.Write("Девятнадцать "); break;
//     }
//
//     Console.WriteLine("учебных заданий");
// }
// else
// {
//     switch (n / 10) //десятки
//     {
//         case 2: Console.Write("Двадцать "); break;
//         case 3: Console.Write("Тридцать "); break;
//         case 4: Console.Write("Сорок "); break;
//         default: Console.Write("Ошибка цифра вне диапазона"); break;
//     }
//
//     switch (n % 10) //единицы
//     {
//         case 0: Console.WriteLine("учебных заданий"); return;
//         case 1: Console.Write("одно учебное задание"); return;
//         case 2: Console.Write("два учебных задания"); return;
//         case 3: Console.Write("три учебных задания"); return;
//         case 4: Console.Write("четыре"); break;
//         case 5: Console.Write("пять"); break;
//         case 6: Console.Write("шесть"); break;
//         case 7: Console.Write("семь"); break;
//         case 8: Console.Write("восемь"); break;
//         case 9: Console.Write("девять"); break;
//     }
//
//     Console.WriteLine(" учебных заданий");
// }





// Case 18. Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например:
// 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// switch (number / 100)
// {
//     case 1: Console.Write("Сто "); break;
//     case 2: Console.Write("Двести "); break;
//     case 3: Console.Write("Триста "); break;
//     case 4: Console.Write("Четыреста "); break;
//     case 5: Console.Write("Пятьсот "); break;
//     case 6: Console.Write("Шестьсот "); break;
//     case 7: Console.Write("Семьсот "); break;
//     case 8: Console.Write("Восемьсот "); break;
//     case 9: Console.Write("Девятьсот "); break;
// }
// if (number % 100 > 10 && number % 100 < 20)
// {
//     switch (number % 100)
//     {
//         case 11: Console.Write("одиннадцать"); return;
//         case 12: Console.Write("двенадцать"); return;
//         case 13: Console.Write("тринадцать"); return;
//         case 14: Console.Write("четырнадцать"); return;
//         case 15: Console.Write("пятнадцать"); return;
//         case 16: Console.Write("шестнадцать"); return;
//         case 17: Console.Write("семнадцать"); return;
//         case 18: Console.Write("восемнадцать"); return;
//         case 19: Console.Write("девятнадцать"); return;
//     }
// }
// switch (number % 100 / 10)
// {
//     case 1: Console.Write("десять"); return;
//     case 2: Console.Write("двадцать "); break;
//     case 3: Console.Write("тридцать "); break;
//     case 4: Console.Write("сорок "); break;
//     case 5: Console.Write("пятьдесят "); break;
//     case 6: Console.Write("шестьдесят "); break;
//     case 7: Console.Write("семьдесят "); break;
//     case 8: Console.Write("восемьдесят "); break;
//     case 9: Console.Write("девяносто "); break;
// }
// switch (number % 100 % 10)
// {
//     case 1: Console.WriteLine("один"); break;
//     case 2: Console.WriteLine("два"); break;
//     case 3: Console.WriteLine("три"); break;
//     case 4: Console.WriteLine("четыре"); break;
//     case 5: Console.WriteLine("пять"); break;
//     case 6: Console.WriteLine("шесть"); break;
//     case 7: Console.WriteLine("семь"); break;
//     case 8: Console.WriteLine("восемь"); break;
//     case 9: Console.WriteLine("девять"); break;
// }


