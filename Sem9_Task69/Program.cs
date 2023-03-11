/*
#69 Напишите прграмму, которая будет принимать 2 числа А и В
возыедите А в степень В с помощью рекурсии
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

long RecPow(int a, int b)
{
    if (b == 0) return 1;
    else return a * RecPow(a, b - 1);
}

long MyPow(int a, int b)
{
    if (b == 2) return 4;
    else return MyPow(a, b / 2) * MyPow(a, b / 2);

}

int num = ReadInputInt("Введите число которое хотите возводить: ");
int numPow = ReadInputInt("Введите число на которое будете возводить: ");
PrintData($"Ответ: {RecPow(num, numPow)}");
PrintData($"Ответ: {MyPow(num, numPow)}");