// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Random rand = new Random();
int Random = rand.Next(100, 1000);
System.Console.WriteLine(Random);
int firstnumber=Random/10;
int Secondnumber=firstnumber%10;
System.Console.WriteLine(Secondnumber);
