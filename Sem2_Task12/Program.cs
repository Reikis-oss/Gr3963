// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondtNum = Convert.ToInt32(Console.ReadLine());
int rem = firstNum % secondtNum;
if(rem == 0)
{
    Console.WriteLine($"Число {firstNum} кратно {secondtNum}");
}
else
Console.WriteLine($"Не кратно. Остаток от деления {firstNum} на {secondtNum} = {rem}");