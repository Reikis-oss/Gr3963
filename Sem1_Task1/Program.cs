// Задача №1
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

Console.Write("Введите 1 число: ");
var number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2 число: ");
var number2 = Convert.ToDouble(Console.ReadLine());

if (number1 == Math.Pow(number2,2))
Console.WriteLine($"Число {number1} является квадратом числа {number2}");
else
Console.WriteLine($"Число {number1} НЕ является квадратом числа {number2}");