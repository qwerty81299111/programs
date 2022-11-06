// прграмма ,которая принимает 2 числа и выводит является ли 1 число кратное второму. Если число 1
// не кратное числу 2 ,то программа выводит остаток от деления
// 34, 5 - не кратно ,остаток 4
// 16, 4 - кратно

Console.Write("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int Multiple(int number1, int number2)
{
    return number1 % number2; 
}
int rest = Multiple(num1, num2);
Console.WriteLine(rest== 0? "кратно": $"не кратно, остаток {rest}");
