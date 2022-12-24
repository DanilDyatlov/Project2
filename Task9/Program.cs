// 9. Напишите программу которая 
// 1. выводит случайное число из отрезка (10,99)
// 2. показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2

int number = new Random().Next(10, 100); //рандомное число 
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// else Console.WriteLine ($"Наибольшая числа => {secondDigit}");

// Console.Write($"Наибольшая числа => ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit); //тернарный оператор проверять условие и возвращает возражение ? это иначе 

//  int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//  Console.WriteLine($"Наибольшая числа => {result} ");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая числа => {maxDigit} ");

int maxDigit1 = MaxDigit(45);
Console.WriteLine($"Наибольшая числа => {maxDigit1} ");

int maxDigit2 = MaxDigit(78);
Console.WriteLine($"Наибольшая числа => {maxDigit2} ");

int MaxDigit(int num) // num = number
 {
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
 }