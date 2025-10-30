// Bool: 1-23 25-28, 30, 34-37

// Путь к сеньору: https://www.youtube.com/watch?v=Ll50o1seax8&list=PL5lgqZ5vlRRYAgjoNF240pV86qP0JOEEg&index=8&ab_channel=%D0%9F%D1%83%D1%82%D1%8C%D0%BASenior-%D1%83
// SimpleCode: https://www.youtube.com/watch?v=9o8opcKO0f0&t=1143s&ab_channel=%23SimpleCode

// !    НЕ
// !=   НЕ РАВНО
// ==   РАВНО
// <    МЕНЬШЕ
// >    БОЛЬШЕ
// <=   МЕНЬШЕ ИЛИ РАВНО
// >=   БОЛЬШЕ ИЛИ РАВНО
// &&   И
// ||   ИЛИ
// ^    ИСКЛЮЧАЮЩЕЕ ИЛИ

// Boolean 1. Дано целое число A. Проверить истинность высказывания: «Число A является положительным».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isPositive = a > 0;
// Console.WriteLine(isPositive);

// Boolean 2. Дано целое число A. Проверить истинность высказывания: «Число A является нечетным».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isOdd = a % 2 != 0;
// Console.WriteLine(isOdd);

// Boolean 3. Дано целое число A. Проверить истинность высказывания: «Число A является четным».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isEven = a % 2 == 0;
// Console.WriteLine(isEven);

// Boolean 4. Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// bool isInequality = a > 2 && b <= 3;
// Console.WriteLine(isInequality);

// Boolean 5. Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A ≥ 0 или B < −2».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// bool isInequality = a >= 0 && b < -2;
// Console.WriteLine(isInequality);

// Boolean 6. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Справедливо двойное неравенство A < B < C».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool isDoubleInequality = a < b && b < c;
// Console.WriteLine(isDoubleInequality);

// Boolean 7. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Число B находится между числами A и C».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool isMiddleNumber = a < b && b < c || a > b && b > c;
// Console.WriteLine(isMiddleNumber);

// Boolean 8. Даны два целых числа: A, B. Проверить истинность высказывания: «Каждое из чисел A и B нечетное».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// bool eachNumberIsOdd = a % 2 != 0 && b % 2 != 0;
// Console.WriteLine(eachNumberIsOdd);

// Boolean 9. Даны два целых числа: A, B. Проверить истинность высказывания: «Хотя бы одно из чисел A и B нечетное»
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// bool atLeastOneIsEven = a % 2 != 0 || b % 2 != 0;
// Console.WriteLine(atLeastOneIsEven);

// Boolean 10. Даны два целых числа: A, B. Проверить истинность высказывания: «Ровно одно из чисел A и B нечетное».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// //bool onlyOneIsOdd1 = (a + b) % 2 != 0; // Variant #1
// //bool onlyOneIsOdd2 = a % 2 != 0 && b % 2 == 0 || b % 2 == 0 && a % 2 != 0; // Variant #2
// bool onlyOneIsOdd3 = a % 2 != 0 ^ b % 2 != 0; // Variant #3
// Console.WriteLine(onlyOneIsOdd3);

// Boolean 11. Даны два целых числа: A, B. Проверить истинность высказывания: «Числа A и B имеют одинаковую четность».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// bool isSameParity = a % 2 == b % 2; // Variant #1
// // bool isSameParity = a % 2 == 0 && b % 2 == 0 || a % 2 != 0 && b % 2 != 0; // Variant #2
// Console.WriteLine(isSameParity);

// Boolean 12. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool eachIsPositive = a > 0 && b > 0 && c > 0;
// Console.WriteLine(eachIsPositive);

// Boolean 13. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool atLeastOnePositive = a > 0 || b > 0 || c > 0;
// Console.WriteLine(atLeastOnePositive);

// Boolean 14. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool onlyOneIsPositive =  (a > 0 && b <= 0 && c <= 0) || (b > 0 && a <= 0 && c <= 0) || (c > 0 && a <= 0 && b <= 0);
// Console.WriteLine(onlyOneIsPositive);

// Boolean 15. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool onlyTwoIsPositive =  (a > 0 && b > 0 && c <= 0) || (a > 0 && c > 0 && b <= 0) || (b > 0 && c > 0 && a <= 0);
// Console.WriteLine(onlyTwoIsPositive); 

// Boolean 16. Дано целое положительное число. Проверить истинность высказывания: «Данное число является четным двузначным».
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool isEvenTwoDigit = n % 2 == 0 && n > 9 && n < 100;
// Console.WriteLine(isEvenTwoDigit);

// Boolean 17. Дано целое положительное число. Проверить истинность высказывания: «Данное число является нечетным трехзначным».
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool isOddThreeDigit = n % 2 != 0 && n > 99 && n < 1000;
// Console.WriteLine(isOddThreeDigit);

// Boolean 18. Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool hasMatchingPair = a == b || b == c || a == c;
// Console.WriteLine(hasMatchingPair);

// Boolean 19. Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара взаимно противоположных».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool hasMutuallyOpposite = a == -b || a == -c || b == -c;
// Console.WriteLine(hasMutuallyOpposite);

// Boolean 20. Дано трехзначное число. Проверить истинность высказывания: «Все цифры данного числа различны».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool allIsDifferent = a != b && b != c ;
// Console.WriteLine(allIsDifferent);

// Boolean 21. Дано трехзначное число. Проверить истинность высказывания: «Цифры данного числа образуют возрастающую последовательность».
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int n1 = n / 100;
// int n2 = n % 100 / 10;
// int n3 = n % 10;
// bool isIncreasingSequence = n1 < n2 && n2 < n3;
// Console.WriteLine(isIncreasingSequence);

// Boolean 22. Дано трехзначное число. Проверить истинность высказывания: «Цифры данного числа образуют возрастающую или убывающую последовательность».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool isIncreasingOrDecreasingSequence = a < b && b < c || a > b && b >c;
// Console.WriteLine(isIncreasingOrDecreasingSequence);

// Boolean 23. Дано четырехзначное число. Проверить истинность высказывания: «Данное число читается одинаково слева направо и справа налево»
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool isPalindrome = (n / 1000) == (n % 10) && (n % 100 / 10) == (n % 1000 / 100); // n1 == n4 && n2 = n3
// Console.WriteLine(isPalindrome);

// Boolean 25. Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй координатной четверти».
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isInSecondQuadrant = x < 0 && y > 0;
// Console.WriteLine(isInSecondQuadrant);

// Boolean 26. Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит в четвертой координатной четверти».
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isInFourthQuadrant = x > 0 && y < 0;
// Console.WriteLine(isInFourthQuadrant);

// Boolean 27. Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй или третьей координатной четверти».
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// // bool isInSecondOrThirdQuadrant = x < 0 && (y > 0 || y < 0); // Variant #1
// bool isInSecondOrThirdQuadrant = x < 0 && y > 0 || x < 0 && y < 0; // Variant #2
// Console.WriteLine(isInSecondOrThirdQuadrant);

// Boolean 28. Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит в первой или третьей координатной четверти».
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isInFirstOrThirdQuadrant = x > 0 && y > 0 || x < 0 && y < 0;
// Console.WriteLine(isInFirstOrThirdQuadrant);

// Boolean 30. Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.
// Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».
// Console.Write("Enter A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Enter B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Enter C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool isEquilateralTriangle = a == b && b == c;
// Console.WriteLine(isEquilateralTriangle);

// Boolean 34. Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8).
// Учитывая, что левое нижнее поле доски (1, 1) является черным, проверить истинность высказывания: «Данное поле является белым».
// Console.Write("Enter X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isWhiteField = (x + y) % 2 != 0;
// Console.WriteLine(isWhiteField);

// Boolean 35. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8).
// Проверить истинность высказывания: «Данные поля имеют одинаковый цвет».
// Console.Write("Enter x1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter x2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// bool haveSameColor = ((x1 + y1) % 2) == ((x2 + y2) % 2);
// Console.WriteLine(haveSameColor);

// Boolean 36. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8).
// Проверить истинность высказывания: «Ладья за один ход может перейти с одного поля на другое»
// Console.Write("Enter X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// bool canRookMove = x1 == x2 || y1 == y2;
// Console.WriteLine(canRookMove);

// Boolean 37. Даны координаты двух различных полей шахматной доски x1,y1, x2, y2 (целые числа, лежащие в диапазоне 1–8).
// Проверить истинность высказывания: «Король за один ход может перейти с одного поля на другое».
// Console.Write("Enter X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter Y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// bool canKingMove = Math.Abs(x1 - x2) < 2 && Math.Abs(y1 - y2) < 2;
// Console.WriteLine(canKingMove);