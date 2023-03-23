// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// int[] FillArrayRandom(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random(); // создаем объект класса (переменную типа Random)
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// void ReverseArray(int[] arr)
// {
//     int temp = 0;
//     for(int i = 0; i < arr.Length/2; i++)
//     {
//         temp = arr[i];
//         arr[i] = arr[arr.Length - i - 1];
//         arr[arr.Length - i - 1] = temp;
//     }
// }

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayRandom(size);

// Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");
// ReverseArray(array);
// Console.WriteLine($"Новый массив: [{string.Join(" ", array)}]");

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Console.Write("Введите длину первой стороны треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину второй стороны треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину третьей стороны треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a+b > c && b+c > a && c+a > b)
//     Console.WriteLine("Треугольник существует");
// else
//     Console.WriteLine("Треугольник не существует");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Первый вариант решения (при помощи рекурсии)
// void PrintBinary(int number)
// {
//     if(number <= 0) // Стоп-кран для рекурсии, останавливает ее
//         return;
    
//     PrintBinary(number/2);
//     Console.Write(number%2);
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintBinary(number);

// второй вариант решения
// int SizeofDif(int num)
// {
//   int count = 0;
//     while (num > 0)
//     {
//         num /= 2;
//         count++;
//     }
//   return count;
// }

// int[] Dif(int num)
// {
//     int[] arr = new int[SizeofDif(num)];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = num % 2;
//         num /= 2;
//     }
//     return arr;
// }

// int[] Reverse(int[] someArr)
// {
//     for (int i = 0; i < someArr.Length/2; i++)
//     {
//         int temp = someArr[i];
//         someArr[i] = someArr[someArr.Length - 1 - i];
//         someArr[someArr.Length - 1 - i] = temp;
//     }
//     return someArr;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] result = Dif(number);
// int[] newArr = Reverse(result);
// Console.WriteLine($"{string.Join(" ",newArr)}");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// void PrintFib(int num)
// {
//     int num1 = 0;
//     int num2 = 1;
//     int num3 = 0;
//     for (int i = 3; i <= num; i++)
//     {
//         num3 = num1 + num2;
//         Console.Write($"{num3} ");
//         num1 = num2;
//         num2 = num3;
//     }
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("0 1 ");
// PrintFib(number);

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(size);

Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");
int[] newArray =  CopyArray(array);
Console.WriteLine($"Новый массив: [{string.Join(" ", newArray)}]");