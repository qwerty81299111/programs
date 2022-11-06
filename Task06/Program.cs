// программа, которая выводит случайное трехзначное число и удаляет 2 цифру
// 456 -> 46

int num = new Random().Next(100,1000);
Console.WriteLine(num);

int FirstLastNumber(int number)
{
    int firstNumber = number / 100;
    int lastNumber = number % 10;
    return firstNumber*10 + lastNumber;
}
Console.WriteLine(FirstLastNumber(num));