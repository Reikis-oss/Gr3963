//  Задача №0
//  Напишите программу, которая на вход принимает число и
//  выдаёт его квадрат (число умноженное само на себя)

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
double number_Pow2 = Math.Pow(number, 2);

Console.WriteLine($"Квадрат числа {number} = {number_Pow2}");

