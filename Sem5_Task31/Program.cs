/*
Задача №31
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

*/
Console.Clear();

int[] Gen1DArr(int len, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

//Считаем сумму отрицательных и положительных чисел;
(int max, int min) SummNegPol(int[] arr)
{
    int polSum = 0;
    int otrSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) polSum += arr[i];
        if (arr[i] < 0) otrSum += arr[i];
    }

    return (polSum, otrSum);
}

int[] mass = Gen1DArr(12, -9, 9);
Print1DArr(mass);
(int posit, int negot) result = SummNegPol(mass);

WriteMess($"Сумма положительных чисел в массиве = {result.posit}" +
          $"\nСумма отрицательных чисел в массиве = {result.negot} ");

