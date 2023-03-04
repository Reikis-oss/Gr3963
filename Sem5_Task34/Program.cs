/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
* Отсортировать массив методом пузырька
* Отсортируйте массив методом подсчета
*/

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Вывод сообщения на экран
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

//Генерируем массив случайными числами
int[] Gen1DArr(int len, int bottom, int top)
{
    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(bottom, top + 1);
    }

    return arr;
}

//Выводим массив на экран
void Print1DArrLine(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Сортировка методом пузырька
int[] BubbleSort(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

//Сортировка методом подсчета
int[] BasicCountingSort(int[] arr, int k)
{
    var count = new int[k + 1];
    for (var i = 0; i < arr.Length; i++)
    {
        count[arr[i]]++;
    }

    var index = 0;
    for (var i = 0; i < count.Length; i++)
    {
        for (var j = 0; j < count[i]; j++)
        {
            arr[index] = i;
            index++;
        }
    }

    return arr;
}

//Переменные для создания массива
int length = ReadInputInt("Введите длину массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
int[] mas = new int[] { };
if (min > max) { (min, max) = (max, min); }

//Вывод массива
mas = Gen1DArr(length, min, max);
Print1DArrLine(mas);
Console.WriteLine();

DateTime d1 = DateTime.Now;
Print1DArrLine(BubbleSort(mas));
WriteMess($"Метод сортировки пузырьком выполняется за: {DateTime.Now-d1}");
Console.WriteLine();

DateTime d2 = DateTime.Now;
Print1DArrLine(BasicCountingSort(mas, max));
WriteMess($"Метод сортировки с помощью подсчета выполняется за: {DateTime.Now-d2}");
Console.WriteLine();