// Задача №26
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.


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
int Summ(int num)
{
    int res = 0;

    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }

    return res;
}

//Обозначаем переменные
int numer = ReadInputInt("Введите число: ");

//Выводим результат
WriteMess($"Сумма цифр в числе: {numer} = {Summ(numer)}");
