/*
 Задача 67
 примает на вход число и возвращает сумму числа
*/
Console.Clear();
//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData(string mess)
{
    Console.WriteLine(mess);
}

int RecSumDig(int num)
{
    if (num == 0) return 0;
    else return num % 10 + RecSumDig(num/10);
}

int numer = ReadInputInt("Введите число: ");
PrintData($"Сума чисел в цифре {numer} = {RecSumDig(numer)}");
