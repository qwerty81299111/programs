// напишите программу, которая а вход принимает одно число (N)
// а на выходе показывает все целые числа в промежутке от -N до N/
// 4-> "-4 -3 -2 -1 0 1 2 3 4"

Console.Write("введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0)
    Console.Write("недопустимое число");
else
{
    int count = -a;

    while (count <= a)
    {
        Console.Write($"{count} ");
        count++;
        
    }

}


