/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.Clear();

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

// Ичет сумму цифр внутри числа
int SummInt(int num)
{
    int res = 0;

    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }

    return res;
}

int SummString(int num)
{
    int res = 0;
    string numString = Convert.ToString(num);
    int len = numString.Length;

    for (int i = 0; i < len; i++)
    {
        res = res + Convert.ToInt32(numString[i]-48);
    }

    return res;
}

//Обозначаем переменные
int numer = ReadInputInt("Введите число: ");

//Запись в переменную нынешнего времени
DateTime d1 = DateTime.Now;
//Выводим результат
WriteMess($"Сумма цифр в числе: {numer} = {SummInt(numer)}");
//Вывод разници между текущим временем и началом выполнения функции
WriteMess($"Время затрачиное на поиск через число: {DateTime.Now - d1}");


//Запись в переменную нынешнего времени
DateTime d2 = DateTime.Now;
//Выводим результат
WriteMess($"Сумма цифр в числе: {numer} = {SummString(numer)}");
//Вывод разници между текущим временем и началом выполнения функции
WriteMess($"Время затрачиное на поиск через строку: {DateTime.Now - d2}");

