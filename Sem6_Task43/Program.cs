/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
Заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
Значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*Найдите площадь треугольника образованного пересечением 3 прямых
*/

//Принимаем из консоли число
double ReadInputDouble(string mess)
{
    Console.Write(mess);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}

void PrindData(string mess)
{
    Console.WriteLine(mess);
}

(double cordX, double cordY) FindIntersectionPoint(double x1Intercepts, double slope1, double x2Intercepts, double slope2)
{
    double cordX = (x2Intercepts - x1Intercepts) / (slope1 - slope2);
    double cordY = slope1 * cordX + x1Intercepts;
    return (cordX, cordY);
}


double b1 = ReadInputDouble("Введите значение для точки пересечения x1 с осью `y`: ");
double k1 = ReadInputDouble("Введите значение для коэффициента наклона прямой для x1: ");
double b2 = ReadInputDouble("Введите значение для точки пересечения x2 с осью `y`: ");
double k2 = ReadInputDouble("Введите значение для коэффициента наклона прямой для x2: ");

(double x, double y) res = FindIntersectionPoint(b1,k1,b2,k2);

PrindData($"Прямые пересекаются в точке: ({res.x};{res.y})");

