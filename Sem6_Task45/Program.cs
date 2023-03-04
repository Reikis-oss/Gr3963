/*
Задача №45
Напишите программу, которая будет создавать копию 
заданного одномерного массива с помощью поэлементного копирования.
*/

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
void Print1DArrLine(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Универсальный метод
object[] CopyArrayStandartTools(params object[] arr)
{
    object[] newMas = new object[arr.Length];

    arr.CopyTo(newMas,0);

    return newMas;
}


int length = ReadInputInt("Введите длину массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
if (min > max) (min, max) = (max, min);

int[] mas = Gen1DArr(length, min, max);

Print1DArrLine(mas);

int[] intArray = CopyArrayStandartTools(mas).Cast<int>().ToArray();
Print1DArrLine(intArray);

