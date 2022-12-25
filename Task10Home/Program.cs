﻿// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число числа :");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 99 && number <= 1000)
{
   number = number / 10 % 10;
   Console.WriteLine($"Вторая цифра числа : {number}");
}
else Console.WriteLine("Введено неверное число");
