﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine());

// int temp = num;
// int rev = 0;

// while (num > 0)
// {

//     int dig = num % 10;
//     rev = rev * 10 + dig;
//     num = num / 10;
// }

// if (temp == rev)
// {
//     Console.WriteLine("Является палиндромом");
// }

// else
// {
//     Console.WriteLine("Не является палиндромом");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координаты точки X1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки Y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки Z1: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки Х2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки Y2: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки Z2: ");
// int z2 = int.Parse(Console.ReadLine());

// Double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно {result:f2}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int index = 1; index <= number; index++)
{
    double result = Math.Pow(index, 3);
    Console.Write($"{result} ");
}

