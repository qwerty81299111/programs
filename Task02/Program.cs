// программа выдает дни недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a == 1)Console.Write("понедельник");
if(a == 2)Console.Write("вторник");
if(a == 3)Console.Write("среда");
if(a == 4)Console.Write("четверг");
if(a == 5)Console.Write("пятница");
if(a == 6)Console.Write("суббота");
if(a == 7)Console.Write("воскресенье");
if(a > 7)Console.Write("такого дня нет");
if(a < 1)Console.Write("такого дня нет");
