// программа, которая принимает на вход 2 числа и проверяет является ли одно число квадратом другого
// 5,25 да
// 8,9 нет


bool Square(int number1, int number2)
{
    return number1*number1  == number2 || number2*number2 == number1;
}

Console.Write("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool square = Square(num1, num2);
Console.WriteLine(square? "да":"нет");