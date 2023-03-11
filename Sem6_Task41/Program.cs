/*
  
   Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    0, 7, 8, -2, -2 -> 2

    1, -7, 567, 89, 223-> 3

    Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.
 */

int count = ReadCount(); // считываем количество нажатий

int positiveCount = CountPositiveNumbers(count); // считаем количество положительных чисел
Console.WriteLine($"Количество положительных чисел: {positiveCount}");


int ReadCount()
{
    Console.Write("Введите количество нажатий: ");
    int count;
    while (!int.TryParse(Console.ReadLine(), out count) || count < 1)
    {
        Console.Write("Некорректный ввод, попробуйте еще раз: ");
    }
    return count;
}


int CountPositiveNumbers(int count)
{
    int positiveCount = 0;
    int prevNumber = 0;
    for (int i = 0; i < count; i++)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        Console.Write(Console.ReadKey().KeyChar);
        
        if (key.KeyChar >= '0' && key.KeyChar <= '9')
        {
            int number = int.Parse(key.KeyChar.ToString());
            if (prevNumber < 0)
            {
                number *= -1;
            }
            positiveCount += (number > 0) ? 1 : 0;
            prevNumber = number;
        }
    }
    return positiveCount;
}
