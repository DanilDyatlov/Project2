// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число : ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельникне выходной"); //
}
else if (number == 2)
{
     Console.WriteLine("Вторник, не выходной");
}
else if (number == 3)
{
    Console.WriteLine("Среда, не выходной");
}
else if (number == 4)
{
    Console.WriteLine("Четверг, не выходной");
}
else if (number == 5)
{
    Console.WriteLine("Пятница, не выходной");
}
else if (number == 6)
{
    Console.WriteLine("Суббота, выходной");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье, выходной");
}
else Console.WriteLine("Нет дня недели таким номером.");