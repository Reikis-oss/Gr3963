/*
Задача №33
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
*/

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
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}


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

bool SearchElem(int[] arr, int num)
{
    bool res = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) 
        {
            res = true;
            
            break;
        }
    }
    return res;
}

int[] mass = Gen1DArr(12, -9, 9);
Print1DArr(mass);
int searchNum = ReadInputInt("Введите число для поиска в массиве: ");

WriteMess(SearchElem(mass, searchNum)? "Данное число найдено": "Данное число не найдено");