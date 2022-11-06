// программа, которая выводит случайное число из отрезка 10,99 и показать наибольшую цифру

// 78->8

int num = new Random().Next(10,100);
Console.WriteLine($"случайное число из диапазона 10 -99 ->{num}");

int firstDigit = num/10;
int secondDigit = num % 10; //78%10=8

if(firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа = {firstDigit}");
else Console.WriteLine($"наибольшая цифра числа {num} = {secondDigit}");

int max = Math.Max(firstDigit, secondDigit);
Console.WriteLine($"наибольшая цифра числа {num} = {max}");





