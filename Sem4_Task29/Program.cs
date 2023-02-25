/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
Ввести с клавиатуры длину массива и диапазон значений элементов.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
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
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//определяем переменные
int length = ReadInputInt("Введите длину массива: ");
int min = ReadInputInt("Введите минимальный элемент последовательности: ");
int max = ReadInputInt("Введите максимальный элемент последовательности: ");
if (min<max) Print1DArr(Gen1DArr(length, min, max));
else Print1DArr(Gen1DArr(length, max, min));