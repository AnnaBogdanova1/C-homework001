// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//   Console.WriteLine ("Введите трехзначное число...");
//   int Number = int.Parse(Console.ReadLine() ?? "0");
//   if ((Number >= 999) || (Number <= 99))
//   {
//     Console.WriteLine ("Вы ввели не трехзначное число");
//   }
//   else
//   {
//     Console.WriteLine ($"Ответ: {Number / 10 % 10}");
//   }

       
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//   Console.WriteLine("Введите число...");
//   int Num = Convert.ToInt32(Console.ReadLine());
//   int Number2;
//   if (Num < 0) Num=-Num;
//   if (Num < 100) Console.WriteLine("ОШИБКА: Третьей цифры нет!");
//   else
//   {
//     while (Num > 1000)
//     {
//       Num = Num/10;
//     }
//     Number2 = Num%10;
//     Console.WriteLine($"ОТВЕТ: {Number2}");
//   }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//   Console.WriteLine ("Введите день недели...");
//   int dayofweek = int.Parse (Console.ReadLine() ?? "0");
//   if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Выходной день.");
//   else if (dayofweek <= 5) Console.WriteLine ("Будний день.");
//   else if (dayofweek > 7) Console.WriteLine ("ОШИБКА!");



