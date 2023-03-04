/*
Задача №39
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод для вывода данных
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

//Метод переворота массива
void SwapArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len / 2; i++)
    {

        (arr[i], arr[len - 1 - i]) = (arr[len - 1 - i], arr[i]);
    }
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];

    for (int i = 0; i < outArr.Length; i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }
    return outArr;
}


int length = ReadInputInt("Введите длину массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
if (min > max) (min, max) = (max, min);

int[] mas = Gen1DArr(length, min, max);
int[] newMas = Gen1DArr(length, min, max);

WriteMess("Первый массив:");
Print1DArrLine(mas);
SwapArray(mas);
Print1DArrLine(mas);
WriteMess("Второй массив:");
Print1DArrLine(newMas);
Print1DArrLine(SwapNewArray(newMas));
