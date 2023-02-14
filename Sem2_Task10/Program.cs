/*
            Задача 10: Напишите программу, которая принимает на вход 
            трёхзначное число и на выходе показывает вторую цифру этого числа.

            564  ->   6
*/
int num = 0;

for (; ; )
{
    Console.Clear();
    Console.Write("Введите трёхзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if ((num > 99) && (num < 1000))
    {
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число " +
                            "\nПопробуйте снова");
        Console.WriteLine("\n\nНажмите любую кнопку для продолжения");
        Console.ReadKey();
    }
}

string stringNum = Convert.ToString(num);
Console.WriteLine($"Вторая цифра числа {num} = {stringNum[1]}");



Console.WriteLine("\n\n\nНажмите любую кнопку для продолжения");
Console.ReadLine();



