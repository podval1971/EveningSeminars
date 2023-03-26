// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

// void RowChange(int[,] arr)
// {
//     int temp = 0;
//     int maxRow = arr.GetLength(0)-1;
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         temp = arr[0,i];
//         arr[0,i] = arr[maxRow,i];
//         arr[maxRow,i] = temp;
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixRandom(row,column);
// PrintMatrix(matrix);
// RowChange(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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

// int[,] ChangeRowColumn(int[,] arr)
// {
//     int[,] arrNew = new int[arr.GetLength(1),arr.GetLength(0)];
//     for (int i = 0; i < arrNew.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrNew.GetLength(1); j++)
//         {
//             arrNew[i,j] = arr[j,i];
//         }
//     }
//     return arrNew;
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixRandom(row,column);
// PrintMatrix(matrix);
// int[,] matrixNew = ChangeRowColumn(matrix);
// Console.WriteLine();
// PrintMatrix(matrixNew);

//Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

void FreqDict(int[,] arr)
{
    int[] res = new int[10];
        
    // for (int i = 0; i < arr.GetLength(0); i++)
    // {
    //     for (int j = 0; j < arr.GetLength(1); j++)
    //     {
    //         for (int k = 0; k < 10; k++)
    //         {
    //             if(arr[i,j] == k) res[k]++;
    //         }
    //     }
    // }

    for (int i = 0; i < arr.GetLength(0); i++) // другой вариант решения через матрицу
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res[arr[i,j]]++;            
        }
    }

    for (int i = 0; i < 10; i++)
    {
        if(res[i] > 0) Console.WriteLine($"Частота значения {i} в массиве равна {res[i]}");
    }
}

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixRandom(row,column);
PrintMatrix(matrix);
Console.WriteLine();
FreqDict(matrix);
