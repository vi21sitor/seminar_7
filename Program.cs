// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
using System.Diagnostics;
using System.Reflection;

String Len(int start,int stop)
{
    if (start <=stop)
    {
        return start + " " + Len(start + 1, stop);
    }
    return "";
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Len(M,N));

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ack(m,n);
Console.WriteLine($"Результат функции Аккермана для чисел {m} и {n} = {result}");
int Ack(int m, int n)
  {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ack(m - 1, 1);
        }
        else
        {
            return Ack(m - 1, Ack(m, n - 1));
        }
    }
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrRev(array, array.Length - 1);
		
void PrintArrRev(int[] arr, int i)
    {
        if (i >= 0)
        {
            Console.Write(arr [i] +" ");
            PrintArrRev(arr, i - 1);
        }
    }		

    