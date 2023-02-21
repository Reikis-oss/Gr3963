/*
Задача №28
Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.

*/
using System.Numerics;

int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

BigInteger FactorialCalc(BigInteger numer)
{   
    BigInteger fact = 1;

    for(int i = 2; i<= numer; i++)
    {
        fact *= i;
    }

    return fact;
}

int num = ReadInputInt("Введите число: ");

WriteMess($"{num}! = {FactorialCalc(num)}");