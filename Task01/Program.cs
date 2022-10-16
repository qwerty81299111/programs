// напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второгго
// a = 25, b = 5 -> da
// a = 2, b = 10 -> net
// a = 9, b = -3 -> da
// a = -3, b = 9 -> net

Console.Write("введите число №1:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число №2:  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a==b*b)
{ 
    Console.Write("да");
}
else
{
    Console.Write("нет");
}
