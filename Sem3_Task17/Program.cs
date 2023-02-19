// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
// Метод который считывает данные из консоли и преобразуют в int
int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintQuterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка в 2 четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 4 четверти");

}

int coordx = (ReadInput("Введите х: "));
int coordy = (ReadInput("Введите y: "));

PrintQuterTest(coordx, coordy);
