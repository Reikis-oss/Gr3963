/*
    Задача 23
        Напишите программу, которая принимает на вход число (N) 
        и выдаёт таблицу кубов чисел от 1 до N.
*/


Console.Clear();

int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string[] LineBuilder(int end, int pow)
{
    string[] res = new string[end];

    for (int i = 0; i < end; i++)
    {
        res[i] = Convert.ToString(Math.Pow(i+1, pow));
    }

    return res;
}


string WriteData(string answer)
{
    string mess = "";
    int les = answer.Length;
    for (int i = 0; i < les; i++)
    {
        if (les == 11) mess += answer;
        if (les == 1) Console.WriteLine(i); //mess += $"     {answer}     ";
    }
    mess += "\r";
    return mess;
}

int N = ReadInput("Введите конечное число: ");

Console.WriteLine(WriteData("___________"));
// Console.WriteLine(WriteData(LineBuilder(N, 1)));


// Console.WriteLine(WriteData(LineBuilder(N,1)));
// Console.WriteLine(WriteData(LineBuilder(N,3)));