// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool bNumber = ((num % 7 == 0) && (num % 23 == 0)); 
Console.WriteLine(bNumber? $"Число {num} кратно 23 и 7" : $"Число {num} не кратно 23 и 7");

if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine($"Число {num} кратно 23 и 7");
}
else
{
    Console.WriteLine($"Число {num} не кратно 23 и 7");   
}
