// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите любое число: ");
string str = Console.ReadLine();
int number = int.Parse(str);
int result = -1;
if(number >= 100)
{
    while(number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
}
if(result == -1)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
Console.WriteLine(result);
}