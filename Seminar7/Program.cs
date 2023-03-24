// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// int[,] FillMatrixRandom(int row, int column)
// {
//     int[,] arr = new int[row,column];
//     Random rnd = new Random(); // создаем объект класса (переменную типа Random)
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = rnd.Next(0, 10);
//         }
//     }
//     return arr;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixRandom(row,column);
// PrintMatrix(matrix);

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// int[,] FillMatrixSum(int row, int column)
// {
//     int[,] arr = new int[row,column];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = i + j;
//         }
//     }
//     return arr;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixSum(row,column);
// PrintMatrix(matrix);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// int[,] FillMatrixRandom(int row, int column)
// {
//     int[,] arr = new int[row,column];
//     Random rnd = new Random(); // создаем объект класса (переменную типа Random)
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = rnd.Next(0, 10);
//         }
//     }
//     return arr;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] PowEvenNumbers(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < arr.GetLength(1); j+=2)
//         {
//             arr[i,j]*= arr[i,j];
//         }
//     }
//     return arr;
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixRandom(row,column);
// PrintMatrix(matrix);
// PowEvenNumbers(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д)
int[,] FillMatrixRandom(int row, int column)
{
    int[,] arr = new int[row,column];
    Random rnd = new Random(); // создаем объект класса (переменную типа Random)
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int SumMainDiagonal(int[,] arr)
{
    int sum = 0;
    int index = 0;
    if(arr.GetLength(0) <= arr.GetLength(1))
        index = arr.GetLength(0);
    else
        index = arr.GetLength(1);

    for (int i = 0; i < index; i++)
    {
        sum = sum + arr[i,i];
    }
    return sum;
}

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixRandom(row,column);
PrintMatrix(matrix);
Console.WriteLine($"Сумма диагональных элементов: {SumMainDiagonal(matrix)}");
