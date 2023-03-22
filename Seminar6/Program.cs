// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray(int[] arr)
{
    int temp = 0;
    for(int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(size);

Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");
ReverseArray(array);
Console.WriteLine($"Новый массив: [{string.Join(" ", array)}]");

