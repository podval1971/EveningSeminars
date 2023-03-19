// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
// Найдите сумму положительных и отрицательных элементов массива.

int[] FillArrayRandom(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random(); // создаем объект класса (переменную типа Random)
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(size);

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        sumPositive+= array[i];
    else
        sumNegative+= array[i];
}

Console.Write("Для массива: ");
Console.WriteLine($"[{string.Join(" ", array)}]");
Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");

