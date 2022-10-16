// программа, которая принимает на ввод трехзначное число и на выходе показывает последнюю цифру
// 456->6

Console.Write("введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a % 10);