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