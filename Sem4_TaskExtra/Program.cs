/*
*Дополнительно: Написать программу которая из имен через запятую 
выберет случайное имя и выведет в терминал Игорь, Антон, Сергей -> Антон 
*/

Console.Clear();

//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

void Print1DArr(string[] arr)
{
    Console.Write("Список имён: ");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.WriteLine(arr[arr.Length - 1]);

}


string name = "Игорь, Антон, Сергей, Евгений, Максим, Владимир, Александр";

Random rnd = new Random();

char[] separators = new char[] { ' ', ',' };
string[] subs = name.Split(separators, StringSplitOptions.RemoveEmptyEntries);

int randomNum = rnd.Next(0, subs.Length);
Print1DArr(subs);
Console.WriteLine();
WriteMess($"Случайно выбраный человек: {subs[randomNum]}");