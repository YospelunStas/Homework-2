// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трёхзначное число: ");
string str = Console.ReadLine();
int number = int.Parse(str);
int num1 = number % 100;
int num2 = num1 / 10;
Console.WriteLine("Вторая цифра числа: " + num2);