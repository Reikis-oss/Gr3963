/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
int[,] Gen2DArrSpirally(int colRow, int colColum)
{
    int[,] res = new int[colRow, colColum];

    int num = 1;
    int row = 0;
    int col = 0;
    while (num <= res.Length)
    {
        // заполнение верхней строки
        for (int i = col; i < colRow - col; i++)
        {
            res[row, i] = num;
            num++;
        }
        // заполнение правого столбца
        for (int i = row + 1; i < colRow - row; i++)
        {
            res[i, colRow - col - 1] = num;
            num++;
        }
        // заполнение нижней строки
        for (int i = colRow - col - 2; i >= col; i--)
        {
            res[colRow - row - 1, i] = num;
            num++;
        }
        // заполнение левого столбца
        for (int i = colRow - row - 2; i > row; i--)
        {
            res[i, col] = num;
            num++;
        }
        // переход к следующему кругу спирали
        row++;
        col++;
    }
return res;
}

// выводим двумерный массив на экран 
void Print2DArrSpirally(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}


int rowAndColum = ReadInputInt("Введите количество строк и столбцов в массиве: ");
int[,] mas = Gen2DArrSpirally(rowAndColum, rowAndColum);
Console.WriteLine("Массив:");
Print2DArrSpirally(mas);
