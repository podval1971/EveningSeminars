/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int ones = num % 10;

    return hundreds * 10 + ones;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

/*
bool IsDivisiable(int number, int ferst, int second)
{
    return number % ferst == 0 && number % second == 0;
    //if (number % ferst == 0 && number % second == 0)
    //    return true;
    //else
    //    return false;
}

Console.Write("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a ferst divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsDivisiable(num, div1, div2));
*/

//Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
/*
int MaxNumber(int num)
{
    int dozens = num / 10;
    int ones = num % 10;

    if (dozens > ones)
        return dozens;
    else
        return ones;
}

int randNumber = new Random().Next(10, 100);

int newNumber = MaxNumber(randNumber);
Console.WriteLine($"The largest value of the digit in the number {randNumber} is {newNumber}");
*/
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool IsSquare(int ferst, int second)
{
    if (ferst > second && ferst == second * second)
        return true;
    else if(ferst < second && second == ferst * ferst)
        return true;
    return false;
}

Console.Write("Input a ferst divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(div1, div2));

