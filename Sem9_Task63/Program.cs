/* 
Задача 63
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
*/

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void LineGenRec(int num)
{
    Console.Write($"{num} ");
    if(num == 1)
    { 
        
    }
    else LineGenRec(num-1);

}

int n = ReadInputInt("Введите число N: ");
LineGenRec(n);