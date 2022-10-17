// программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 161 
// 46

Console.Write("введите число");
int num = Convert.ToInt32(Console.ReadLine());

bool Multiple(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

bool multiple = Multiple(num);
Console.WriteLine(multiple? "да" : "нет");