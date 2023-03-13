// Задача 17. Напишите программу, которая принимает на вход координаты точки X и Y,
// причем X и Y не равны 0, и выдает номер четверти плоскости, в которой находится эта точка

Console.Write("Input a X coordinat: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Y coordinat: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x>0 && y>0)
{
    Console.Write("Point lies in the first quarter");
}
else if(x<0 && y>0)
{
    Console.Write("Point lies in the second quarter");
}
else if(x<0 && y<0)
{
    Console.Write("Point lies in the third quarter");
}
else if(x>0 && y<0)
{
    Console.Write("Point lies in the fourth quarter");
}
else
{
    Console.Write("Point lies on the axis");
}

