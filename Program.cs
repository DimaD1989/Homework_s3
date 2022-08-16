// Console.Write("Введите пятизначное число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// while (num<10000 && num<99999)
// {
//     Console.Write("Вы ввели не пятизначное число, исправьте: ");
//     int num2=Convert.ToInt32(Console.ReadLine());
//     if (num2>9999 && num2<100000)
//     {
//         num=num2;
//     }
// }
// if (num/10000==num%10 && num/1000%10==num/10%10)
//     {
//         Console.WriteLine($"Число {num} является палиндромом");
//     }
// else
// {
//     Console.WriteLine($"Число {num} не является палиндромом");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int count = 1;
// while (count <= num)
// {
//     Console.Write($"|{Math.Pow(count++, 3)}| ");
}