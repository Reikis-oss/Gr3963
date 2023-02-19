/*
    Задача 21
        Напишите программу, которая принимает на вход координаты двух точек 
    и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84

    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

static double CalcLen3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double A = (x2 - x1) * (x2 - x1);
    double B = (y2 - y1) * (y2 - y1);
    double C = (z2 - z1) * (z2 - z1);
    return Math.Sqrt(A + B + C);
}

static void PrintData(string mess, double val)
{
    Console.Write($"{mess} {val}");
}

int coordX1 = ReadInput("Введите кординату x точки a: ");
int coordY1 = ReadInput("Введите кординату y точки a: ");
int coordZ1 = ReadInput("Введите кординату z точки a: ");
int coordX2 = ReadInput("Введите кординату x точки b: ");
int coordY2 = ReadInput("Введите кординату y точки b: ");
int coordZ2 = ReadInput("Введите кординату z точки b: ");


double res = CalcLen3D(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2);
PrintData("Растояние между точками = ", res);
