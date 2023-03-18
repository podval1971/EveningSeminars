// Задача 24. Напишите программу, которая принимает число (А) и выдает сумму чисел от 1 до А.

int Sum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum+=i;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма от 1 до {number} = {Sum(number)}");
