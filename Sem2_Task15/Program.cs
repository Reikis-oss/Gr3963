/*
               Задача 15: Напишите программу, которая принимает на вход цифру, 
               обозначающую день недели, и проверяет, является ли этот день выходным.
*/


Console.Clear();

Dictionary<int, string> dic = new Dictionary<int, string>
{
    [1] = "Рабочий день",
    [2] = "Рабочий день",
    [3] = "Рабочий день",
    [4] = "Рабочий день",
    [5] = "Рабочий день",
    [6] = "Выходной",
    [7] = "Выходной",
};


for (; ; )
{
    Console.Write("Введите цифру от 1 до 7: ");
    int dayOfWeek = Convert.ToInt32(Console.ReadLine());

    if ((dayOfWeek > 0) && (dayOfWeek < 8))
    {
        Console.WriteLine($"Выбраное вами число является - {dic[dayOfWeek]}");
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели не день недели" +
            "\nпропробуйте ещё раз" +
            "\n\n\n Нажмите любую кнопку для продолжения");
        Console.ReadKey();

    }
}
