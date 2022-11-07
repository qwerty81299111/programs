// программа ,принимает на вход координаты x и y, причем x y не равны нулю и 
//выдает номер четверти плоскости в которой находится эта точка


Console.WriteLine("введите координаты точки");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0 ? $"указанные координаты соответствуют четверти -> {quarter}": "введены нкорректные координаты";
Console.WriteLine(result);