/*
Задача 65
Задайте значения M и N. Напишите программу, 
которая найдёт все натуральные элементы в промежутке от M до N.
*/

// Чтение данных из консоли
int ReadInputInt(string mess)
{
    Console.Write(mess);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintData(string mes)
{
    Console.WriteLine(mes);
}

string RecMN(int m, int n)
{
    string res = string.Empty;
    if (m >= n)
    {
        res = n.ToString();
    }
    else
    {
        res = res + m + " " + RecMN(m + 1, n);
    }
    return res;
}

int number1 = ReadInputInt("Введите число M: ");
int number2 = ReadInputInt("Введите число N: ");
string resultLine = RecMN(number1, number2);
PrintData(resultLine);