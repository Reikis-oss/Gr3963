/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите все пары в массиве и выведите пользователю
*/

Console.Clear();

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
int[] Gen1DArrRandom(int len, int bottom, int top)
{
    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(bottom, top + 1);
    }

    return arr;
}

//Генерируем массив числами по порядку с 1
int[] Gen1DArr(int len, int bottom, int top)
{
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = i+1;
    }

    return arr;
}

//Вывод массива на экран в 1 строчку
void Print1DArrLine(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Вывод массива на экран в 1 столбец
void Print1DArrСolumn(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\n");
    }
}

//Поиск пар в массиве
string[] PairSearch(int[] arr)
{
    string[] buf = new string[arr.Length];
    int countBuf = 0;
    int[] indexFound = Gen1DArr(arr.Length + 1, -10, -10);
    int countIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        int firsNum = arr[i];
        if (Array.IndexOf(indexFound, i) == -1)
        {
            indexFound[countIndex] = i;
            countIndex++;
        }
        else
        {
            continue;
        }

        for (int j = 1; j < arr.Length; j++)
        {

            if (arr[j] == firsNum && j != i && j > i && Array.IndexOf(indexFound, j) == -1)
            {
                buf[countBuf] = $"Пара числел {firsNum} найдена на позициях {i + 1} и {j + 1}";
                countBuf++;
                if (Array.IndexOf(indexFound, j) == -1)
                {
                    indexFound[countIndex] = j;
                    countIndex++;
                }
                break;
            }
        }

    }
    return buf;
}


//определяем переменные
int length = ReadInputInt("Введите длину массива: ");
int min = ReadInputInt("Введите 1 границу последовательности: ");
int max = ReadInputInt("Введите 2 границу последовательности: ");
int[] mas = new int[] { };
if (min < max) mas = Gen1DArrRandom(length, min, max);
else mas = Gen1DArrRandom(length, max, min);
int[] indexMas = Gen1DArr(length, 0, length);

Print1DArrLine(mas);
Print1DArrLine(indexMas);
Console.WriteLine();
Print1DArrСolumn(PairSearch(mas));
