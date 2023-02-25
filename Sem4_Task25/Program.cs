/*
    Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
        и возводит число A в натуральную степень B.
    
    3, 5 -> 243 (3⁵)

    2, 4 -> 16
*/

Console.Clear();

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}


//принимаем из консоли символ
char ReadInputChar(string mess)
{
    Console.Write(mess);
    return Convert.ToChar(Console.ReadLine() ?? "0");
}


//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

//Калькулятор
double Calculate(int A, char op, int B)
{
    switch (op)
    {
        case '+': return A + B;
        case '-': return A - B;
        case '*': return A * B;
        case '/': return A / B;
        case '^': return Math.Pow(A, B);
        default:
            WriteMess("\nНеизвестная операция");
            return 0;
    }
}


//Обозначаем переменные
int numberA = ReadInputInt("Введите первое число: ");

char sign = ReadInputChar("" +
        "\nВыберете действие:" +
        "\n Сложения: +" +
        "\n Вычитания: -" +
        "\n Умножения: *" +
        "\n Деления: /" +
        "\n Возведения в степень: ^" +
        "\n Ваш выбор: ");

int numberB = ReadInputInt("Введите второе число: ");
double res = Calculate(numberA, sign, numberB);

//Выводим результат
WriteMess($" {numberA} {sign} {numberB} = {res}");
