internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает два числа и выдаёт, 
        // какое число большее, а какое меньшее

        Console.Clear();
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

            if (Math.Max(num1, num2) == num1)
            Console.WriteLine($"Максимальное число = {num1}");
            else 
            Console.WriteLine($"Максимальное число = {num2}");

    }
}