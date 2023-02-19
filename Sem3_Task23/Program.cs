/*
    Задача 23
        Напишите программу, которая принимает на вход число (N) 
        и выдаёт таблицу кубов чисел от 1 до N.
*/
Console.Clear(); //очистка терминала

int ReadInput(string mess) // чтение данных из консоли
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string[] MassBuilder(int end, int pow) // создание массива из чисел
{
    string[] res = new string[end];

    for (int i = 0; i < end; i++)
    {
        res[i] = Convert.ToString(Math.Pow(i + 1, pow));
    }

    return res;
}
string[] LineBuilder(int end) // создание массива из "-" в длину массива чисел
{
    string[] res = new string[end];

    for (int i = 0; i < end; i++)
    {
        res[i] = "------------";
    }

    return res;
}

void WriteMass(string[] mess) // Вывод массива
{
    for (int i = 0; i < mess.Length; i++)
    {
        if (mess[i].Length == 1) Console.Write($"|     {mess[i]}     ");
        if (mess[i].Length == 2) Console.Write( $"|    {mess[i]}     ");
        if (mess[i].Length == 3) Console.Write( $"|    {mess[i]}    ");
        if (mess[i].Length == 4) Console.Write(  $"|   {mess[i]}    ");
        if (mess[i].Length == 5) Console.Write(  $"|   {mess[i]}   ");
        if (mess[i].Length == 7) Console.Write(   $"|  {mess[i]}   ");
        if (mess[i].Length == 8) Console.Write(   $"|  {mess[i]}  ");
        if (mess[i].Length == 9) Console.Write(    $"| {mess[i]} ");
        if (mess[i].Length == 10) Console.Write(   $"| {mess[i]}");
        if (mess[i].Length == 11) Console.Write(    $"|{mess[i]}");
        if (mess[i].Length == 12) Console.Write(     $"{mess[i]}");
    }
    if (mess[1].Length != 12) Console.WriteLine("|");
    else Console.WriteLine("-");
}

int N = ReadInput("Введите конечное число: "); // обращение к функции ReadInput и запись в переменную

//обращение к функциям
WriteMass(LineBuilder(N));
WriteMass(MassBuilder(N, 1));
WriteMass(LineBuilder(N));
WriteMass(MassBuilder(N, 3));
WriteMass(LineBuilder(N));
