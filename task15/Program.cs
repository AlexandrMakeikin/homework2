// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A == 1)
{
    System.Console.Write("понедельник");
}
else if (A == 2)
{
    System.Console.Write("вторник");
}
else if (A == 3)
{
    System.Console.Write("среда");
}
else if (A == 4)
{
    System.Console.Write("четверг");
}
else if (A == 5)
{
    System.Console.Write("пятница");
}
else if (A == 6)
{
    System.Console.Write("суббота");
}
else if (A == 7)
{
    System.Console.Write("воскресенье");

}
else System.Console.WriteLine("такого дня недели не существует");
if (A == 6 || A == 7)
{
    System.Console.Write(" - выходной");
}
if (A == 1 || A == 2 || A == 3 || A == 4 || A == 5)
{
    System.Console.WriteLine("- Ура,любимая работа");
}
