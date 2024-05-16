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

/* Задача 1 - Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/
/*
bool IsSumDigitOdd(int sum)
{
    if (sum % 2 == 0) return false;
    return true;
}
int FindSumDigit(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.WriteLine("Введите целое число или 'q' для выхода: ");

while (true)
{
    string input = Console.ReadLine();
    if (input == "q") break;
    int inputNumber = 0;
    if (int.TryParse(input, out inputNumber))
    {
        inputNumber = Convert.ToInt32(input);
        if (IsSumDigitOdd(FindSumDigit(inputNumber)) == false) break;
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
    }
}
*/

/* Задача 2 - Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
/*
int [] CreateRandomArray (int sizeArray)
{
    int [] createdArray = new int [sizeArray];
    Random rand = new();
    for (int i = 0; i < createdArray.Length; i++)
    {
        createdArray[i] = new Random().Next(100, 1000);
    }
    return createdArray;
}
void PrintArray (int [] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

Console.Write("Count of elements in array is: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int [] arrayHowemorkTask2 = CreateRandomArray(arraySize);
PrintArray(arrayHowemorkTask2);
Console.WriteLine();
int evenCount = 0;
for (int i = 0; i < arrayHowemorkTask2.Length; i++)
{
    if (arrayHowemorkTask2[i] % 2 == 0) evenCount++;
}
Console.WriteLine($"There are {evenCount} even elements in array.");
*/

/* Задача 3 - Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)
*/
/*
int [] CreateRandomArray(int size)
{
    int [] createdArray = new int [size];
    Random rand = new Random();
    for (int i = 0; i < createdArray.Length; i++)
    {
        createdArray[i] = new Random().Next(1, 100);
    }
    return createdArray;
}
void PrintArray (int [] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

int sizeArray = 10;
int [] arrayHomeworkTask3 = CreateRandomArray(sizeArray);
PrintArray(arrayHomeworkTask3);
for (int i = 0; i < arrayHomeworkTask3.Length/2; i++)
{
    int temp = arrayHomeworkTask3[i];
    arrayHomeworkTask3[i]=arrayHomeworkTask3[arrayHomeworkTask3.Length-1-i];
    arrayHomeworkTask3[arrayHomeworkTask3.Length-i-1] = temp;
}
Console.WriteLine();
PrintArray(arrayHomeworkTask3);
*/