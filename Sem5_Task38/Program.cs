/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
Отсортируйте массив методом вставки
*/

Console.Clear();

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
double[] Gen1DArrRandom(int len, int bottom, int top)
{
    Random rnd = new Random();
    double[] arr = new double[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = Math.Round(rnd.Next(bottom, top) + rnd.NextDouble(), 3);
    }

    return arr;
}

//Вывод массива на экран в 1 строчку
void Print1DArrLine(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"({arr[i]})\t");
    }
    Console.WriteLine($"({arr[arr.Length - 1]})]");
}

//Поиск разницы между максимальным и минимальным элементом
(double, double, double) SearchDiffMaxMin(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    return (max - min, min, max);
}


int length = ReadInputInt("Введите длину массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
double[] mas = new double[] { };
if (min < max) mas = Gen1DArrRandom(length, min, max);
else mas = Gen1DArrRandom(length, max, min);

Print1DArrLine(mas);
(double, double, double) res = SearchDiffMaxMin(mas);
Console.WriteLine($"\nМинимальное число = {res.Item2} " +
                  $"\nМаксимальное число = {res.Item3}" +
                  $"\nРазница между числами = {res.Item1}");