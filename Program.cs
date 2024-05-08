// Задача1. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа
// в промежутке от M до N.

// void MtoN (int M, int N)
// {
//     if (M>N)
//     {
//         MtoN(M-1,N);
//         System.Console.Write(M + " ");   
//     }
//     else if (M<N)
//     {
//         MtoN(N-1,M);
//         System.Console.Write(N + " ");
//     }
// }

// MtoN(5,25);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// int Aker(int m, int n)
// {
//     if(m==0)
//     {
//         return n + 1;
//     }
//     else if(n==0)
//     {
//         return Aker(m-1, 1);
//     }
//     else
//     {
//         return Aker(m-1, Aker(m, n-1));
//     }
// }
// System.Console.WriteLine("Please input first positive number: ");
// int m=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Please input second positive number: ");
// int n=Convert.ToInt32(Console.ReadLine());
// int result = Aker(m,n);
// System.Console.WriteLine($"Aker is: {result}");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// int [] CrArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void NewArray(int[] array, int i)
// {
//     if (i < array.Length)
//     {
//         NewArray(array, i + 1);
//         System.Console.Write(array[i] + " ");
//     }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Arr size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("minimum value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("maximum value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CrArray(size, min, max);
// PrintArray(array);
// NewArray(array, 0);
// System.Console.WriteLine();
