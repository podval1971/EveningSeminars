// Задача 24. Напишите программу, которая принимает число (А) и выдает сумму чисел от 1 до А.

// int Sum(int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма от 1 до {number} = {Sum(number)}");


// Задача 26. Напишите программу, которая принимает число и выдает количество цифр в числе.

// int DigitNumber(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num/=10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abs() - модуль числа

// Console.WriteLine($"В числе {number} {DigitNumber(number)} цифр");

// // Другой вариант решения - через определение длины строки символов
// Console.Write("Введите число: ");
// string str = Console.ReadLine(); // число вводится как строка символов

// if(int.TryParse(str, out int number)) // проверка что все символы в строке - цифры
// {
//     Console.WriteLine($"В числе {number} {str.Length} цифр"); //определяется количество символов в строке
// }
// else
// {
//     Console.WriteLine("Это не число");
// } 


// Задача 28. Напишите программу, которая принимает число N и выдает произведение чисел от 1 до N.

// int Multiplication(int num)
// {
//    int count = 1;
//    for (int i = 1; i <= num; i++) 
//    {
//        count*=i;
//    }
//    return count;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Произведение чисел от 1 до {number} равно {Multiplication(number)}");

// Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке.

// void FillArray(int[] collectoin)
// {
//     int length = collectoin.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collectoin[index] = new Random().Next(0,2);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);

// Другой вариант решения
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random(); // создаем объект класса (переменную типа Random)
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine($"[{string.Join(" ", array)}]"); // выводит массив без применения цикла как строку, первый аргумент - разделитель (, или пробел), второй - элементы