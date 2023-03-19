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
// int[] array = FillArrayRandom(size);

// int sumPositive = 0;
// int sumNegative = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//         sumPositive+= array[i];
//     else
//         sumNegative+= array[i];
// }

// Console.Write("Для массива: ");
// Console.WriteLine($"[{string.Join(" ", array)}]");
// Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] array = FillArrayRandom(size);
// int[] arrNeg = new int[size];

// for (int i = 0; i < arrNeg.Length; i++)
// {
//     arrNeg[i] = array[i]*-1;
// }
// Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");
// Console.WriteLine($"Перевернутый массив: [{string.Join(" ", arrNeg)}]");

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] array = FillArrayRandom(size);
Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");
Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] == number)
//     {
//         Console.WriteLine($"Число {number} в массиве ЕСТЬ");
//         return;
//     }
// }
// Console.WriteLine($"Числа {number} в массиве НЕТ");

//  другой вариант решения:
string result = "НЕТ";
for (int i = 0; i < array.Length; i++)
{
    if(array[i] == number)
    {
        result = "ЕСТЬ";
        break;
    }
}
Console.WriteLine($"Число {number} в массиве {result}");