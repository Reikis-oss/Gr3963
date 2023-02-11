

internal partial class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход три числа 
        // и выдаёт максимальное из этих чисел.

        Console.Clear();
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        if (Math.Max(num1, num2) == num1)
        {
            if (Math.Max(num1, num3) == num1)
                Console.WriteLine($"Максимальное число = {num1}");
            else
                Console.WriteLine($"Максимальное число = {num3}");
        }
        else if (Math.Max(num2, num3) == num2)
            Console.WriteLine($"Максимальное число = {num2}");
        else
            Console.WriteLine($"Максимальное число = {num3}");
    }
}