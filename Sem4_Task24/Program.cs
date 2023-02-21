/*
    Задача 24.
    принимает на вход число а и выдаёт сумму чисел от 1 до а

*/
Console.Clear();
//Запрос данных у пользователя
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Вывод данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

//Считает сумму от 1 до введеного числа простым способом
long SumSimple(long numA)
{
    long sum = 0;

    for (int i = 1; i <= numA; i++)
    {
        sum += i;
    }
    return sum;
}

//Считает сумму от 1 до введеного числа Методом Гауса
long SumGausse(long numA)
{
    return ((1 + numA) * numA) / 2;
}


int numerA = ReadInputInt("Введите число А: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numerA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGausse(numerA);
Console.WriteLine(DateTime.Now - d2);


WriteMess($"Сумма чисел от 1 до {numerA} = {res1} \t Простым способом)");
WriteMess($"Сумма чисел от 1 до {numerA} = {res2} \t Методом Гауса)");
