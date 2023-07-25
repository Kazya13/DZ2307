// Задача 10. Напишите программу, которая 
// принимает на вход положительное трёхзначное число и
//  на выходе показывает вторую цифру этого числа.
// 
// 456 -> 5
// 782 -> 8
// 918 -> 1

vvod: Console.WriteLine("Введите 3значное число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не 3 значное число, введите 3 значное");
    goto vvod;
}
int secondDigit = (number / 10) % 10;

Console.WriteLine("Вторая цифра 3значного числа: " + secondDigit);

