internal partial class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает число и выдаёт, 
        // является ли число чётным (делится ли оно на два без остатка).

        Console.Clear();
        Console.Write("Введите первое число: ");
        int num = int.Parse(Console.ReadLine());

        switch (num % 2)
        {
            case 0:
                Console.WriteLine($"Число: {num} - четное");
                break;
            case 1:
                Console.WriteLine($"Число: {num} - нечётное");
                break;
        }
    }
}
