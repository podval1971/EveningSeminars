// Задача 17. Напишите программу, которая принимает на вход координаты точки X и Y,
// причем X и Y не равны 0, и выдает номер четверти плоскости, в которой находится эта точка
/*
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
*/

/*
double number = 5;

//double res = Math.Pow(number, 2); // возведение числа number в степень 2
//Console.WriteLine(res);

double res = Math.Sqrt(number); //извлечение квадратного корня из number
res = Math.Round(res, 4); //округление до 4 знака
Console.WriteLine(res);
*/

// Задача 18. Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точсек в этой четверти (x и y).
/*
string[] quarters = {"x>0, y>0", "x<0, y>0", "x<0, y<0", "x>0, y<0"};

Console.Write("Input quarter number: ");
int quart = Convert.ToInt32(Console.ReadLine());

if(quart>=1 && quart<=4)
    Console.WriteLine(quarters[quart-1]);
else
    Console.WriteLine("Wrong quarter number");
*/

//Задача 21. Напишите программу, которая принимает координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distance2D(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return Math.Round(res, 2);
}

Console.Write("Input first X coordinat: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first Y coordinat: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second X coordinat: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second Y coordinat: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance2D(x1, y1, x2, y2);
Console.WriteLine($"Distance = {distance}");
*/

//Задача 22. Напишите программу, которая принимает число (N) и выдает таблицу квадратов чисел от 1 до N.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=number; i++)
    Console.Write($"{Math.Pow(i, 2)} ");
