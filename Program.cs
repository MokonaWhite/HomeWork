// ДЗ

/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

// void NumberInIntervel(int start, int end)
// {
// if(start == end)
// {
//     Console.Write(start);
//     return;
// }
// Console.Write(start + " ");
// NumberInIntervel(start + 1, end);
// }

// NumberInIntervel(5, 15);

/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

// int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (n == 0)
//             return AckermannFunction(m - 1, 1);
//         else
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }

//         int m = 2;
//         int n = 4;
//         Console.WriteLine($"AckermannFunction({m}, {n}) = {AckermannFunction(m, n)}");
//         // сперва не понял, что она не для каждого числа вызывается...


/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы. */


// int[] CreateArray(int size) 
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++) 
//     {
//         array[i] = rnd.Next(100);
//     }
// return array;
// }

// void PrintArray (int[] array) 
// {
// for(int i = 0; i < array.Length; i++) 
// {
//     {
//         Console.Write(array[i] + " "); 
//     } 
// }
// }

// void PrintReverseArray(int[]array, int size)
// {
//     if(size == 0)
//     {
//         Console.Write(array[size]);
//         return;
//     }
//     Console.Write(array[size - 1] + " ");
//     PrintReverseArray(array, size - 1);
// }


// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] result = CreateArray(size);
// Console.Write("Массив: [] ");
// PrintArray(result); 

// Console.Write("\nПеревернутый массив:  ");  
// PrintReverseArray(result, size);