Console.Clear();

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Создаём двумерный массив из чисел Фмбоначчи
int[,] Gen2DArrFibonachi(int row, int colum)
{
    int[,] arr = new int[row, colum]; // создаем двумерный массив для хранения чисел Фибоначчи
                                      // первые два числа Фибоначчи равны 1
    arr[0, 0] = 0;
    arr[0, 1] = 1;


    if (colum > 2)
    {
        // заполняем первую строку массива остальными числами Фибоначчи
        for (int i = 2; i < colum; i++)
        {
            arr[0, i] = arr[0, i - 1] + arr[0, i - 2];
        }
    }

    // заполняем остальные строки массива на основе предыдущей строки
    for (int i = 1; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            if (j == 0)
            {
                arr[i, j] = arr[i - 1, colum - 2] + arr[i - 1, colum - 1];
            }
            else if (j == 1)
            {
                arr[i, j] = arr[i, j - 1] + arr[i - 1, colum - 1];
            }
            else
            {
                arr[i, j] = arr[i, j - 1] + arr[i, j - 2];
            }
        }
    }



    return arr;
}

// выводим двумерный массив на экран с разукрашиванием элемента если он равен тому что ввёл пользователь
void Print2DArr(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(arr[i, j] + "\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write(arr[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }

}

//Создаём одномерный массив из чисел Фмбоначчи
int[] Gen1DArrFibonachi(int len)
{
    int[] arr = new int[len];
    arr[0] = 0;
    arr[1] = 1;

    for (int i = 2; i < len; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }

    return arr;
}

//Выводим массив на экран в 1 строку
void Print1DArrLine(int[] arr, int num)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (num == arr[i])
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{arr[i]},\t");
            Console.ResetColor();
        }
        else
        {
            Console.Write($"{arr[i]},\t");
        }
    }
    if (num == arr[arr.Length - 1])
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{arr[arr.Length - 1]}");
        Console.ResetColor();
        Console.WriteLine("]");
    }
    else
    {
        Console.WriteLine($"{arr[arr.Length - 1]}]");
    }
}

//Выводим массив на экран в 1 линию
void Print1DArrСolumn(int[] arr, int num)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{arr[i]}\n");
            Console.ResetColor();
        }
        else
        {
            Console.Write($"{arr[i]}\n");
        }
    }
}

int countRow = ReadInputInt("Введите количество строк для двумерного массива: ");
int countColum = ReadInputInt("Введите количество столбцов для двумерного массива: ");
int numer = ReadInputInt("Введите искомое число: ");

if (countRow == 1 && countColum == 1)
{
    if (numer == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(0);
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine(0);
    }

}
else if (countRow == 1 || countColum == 1)
{


    if (countRow == 1)
    {
        int[] fbn = Gen1DArrFibonachi(countColum);
        Print1DArrLine(fbn, numer);
    }

    if (countColum == 1)
    {
        int[] fbn = Gen1DArrFibonachi(countRow);
        Print1DArrСolumn(fbn, numer);
    }
}
else if (countRow > 1 && countColum > 1)
{
    int[,] fbn = Gen2DArrFibonachi(countRow, countColum);
    Print2DArr(fbn, numer);
}




