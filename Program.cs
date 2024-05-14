// Семинар 4 - Функции

/* Задание 1 - Задайте одномерный массив, заполненный случайными числами. 
Определите количество простых чисел в этом массиве.

Примеры:
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3
*/
/*
int[] CreateRandomArray(int sizeArray, int minV, int maxV)
{
    int[] createdArray = new int[sizeArray];
    Random rand = new Random();
    for (int i = 0; i < sizeArray; i++)
    {
        createdArray[i] = new Random().Next(minV, maxV + 1);
    }
    return createdArray;
}
void PrintArray(int[] array)
{
    foreach (int val in array)
    {
        Console.Write($"{val} ");
    }
}
bool IsItPrimeNumber(int val)
{
    for (int k = 2; k < val; k++)
    {
        if (val % k == 0) 
        return false;
    }
    return true;
}
int CountOfPrimeNumber(int[] array)
{
    int count = 0;
    foreach(int val in array)
    {
        if (IsItPrimeNumber(val))
        count ++;
    }
    return count;
}

int sizeTask1 = 10;
int minV = 1;
int maxV = 100;

int [] arrayTask1 = CreateRandomArray(sizeTask1,minV,maxV);
PrintArray(arrayTask1);
int count = CountOfPrimeNumber(arrayTask1);
Console.WriteLine();
Console.WriteLine(count);
*/

/* Задание 2 - Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

Пример:
[1 5 11 21 81 4 0 91 2 3] => 2
*/
/*
int[] CreateRandomArray(int sizeArray, int minV, int maxV)
{
    int[] createdArray = new int[sizeArray];
    Random rand = new Random();
    for (int i = 0; i < sizeArray; i++)
    {
        createdArray[i] = new Random().Next(minV, maxV + 1);
    }
    return createdArray;
}
void PrintArray(int[] array)
{
    foreach (int val in array)
    {
        Console.Write($"{val} ");
    }
}
int CountOfElements(int[] array)
{
    int count = 0;
    foreach (int elem in array)
    {
        if (elem % 10 == 1 && elem % 7 == 0)
        count ++;
    }
    return count;
}

Console.Write("Count of elements in array is: ");
int sizeTask2 = Convert.ToInt32(Console.ReadLine());
int[] arrayTask2 = CreateRandomArray(sizeTask2, 1, 99);
PrintArray(arrayTask2);
Console.WriteLine();
Console.WriteLine("Total: " + CountOfElements(arrayTask2));
*/

// Домашнее задание!