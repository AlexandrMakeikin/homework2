// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    System.Console.WriteLine("такого числа нет");
}
if (number > 100 && number < 1000)
{
    System.Console.WriteLine($" {number % 10} ");

}
if (number > 1000 && number < 10000)
{
    System.Console.WriteLine($" {number % 100 / 10} ");
}
if (number > 10000 && number < 100000)
{
    System.Console.WriteLine($" {number % 1000 / 100} ");
}
if (number > 100000 && number < 1000000)
{
    System.Console.WriteLine($" {number % 10000 / 1000} ");
}
if (number > 1000000 && number < 10000000)
{
    System.Console.WriteLine($" {number % 100000 / 10000} ");
}
if (number > 10000000 && number < 100000000)
{
    System.Console.WriteLine($" {number % 1000000 / 100000} ");
}
