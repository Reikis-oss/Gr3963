/*
                Задача 13: Напишите программу, которая выводит 
                третью цифру заданного числа или сообщает, что третьей цифры нет.

                564         ->  6
                541546584   ->  1
*/

for (; ; )
{
    Console.Clear();
    Console.Write("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int numLength = num.ToString().Length;
    if (numLength > 2)
    {
        int i = 0;
        for (; i < numLength - 3; i++)
        {
        }
        num = (int)(num / Math.Pow(10, i));
        Console.WriteLine($"Третья цифра заданного числа = {num % 10}");
        break;
    }
    else
    {
        Console.WriteLine("Третьей цифры нет" +
                                "\nПопробуйте ещё раз");
        Console.WriteLine("\n\nНажмите любую кнопку для продолжения");
        Console.ReadKey();
    }
}