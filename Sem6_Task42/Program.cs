/*
Задача №42
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
*/

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}


int num = ReadInputInt("Введите число: ");

string DecToBin(int numer)
{
    string result = string.Empty;
    while (numer > 0)
    {
        result = numer % 2 + result;
        numer /= 2;
    }
    return result;
}

Console.WriteLine("Число {0} в двоичной системе = {1}",num , DecToBin(num));