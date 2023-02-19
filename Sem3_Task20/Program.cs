// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

static double CalcLen2D(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
}

static void PrintData(string mess, double val)
{
    Console.Write($"{mess} {val}");
}

int coordX1 = ReadInput("Введите кординату x точки a: ");
int coordY1 = ReadInput("Введите кординату y точки a: ");
int coordX2 = ReadInput("Введите кординату x точки b: ");
int coordY2 = ReadInput("Введите кординату y точки b: ");

double res = CalcLen2D(coordX1, coordY1, coordX2, coordY2);
PrintData("Растояние между точками = ", res);