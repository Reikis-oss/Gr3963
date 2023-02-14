// Напишите программу, которая случайное число из отрезка и 
// выводит максимально число этого числа


Console.Clear();

//Вариант1
Random numSintezator = new Random();
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine($"Рандомное число = {rndNumber}");
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

Console.WriteLine($"Максимально число = {Math.Max(firstNum, secondNum)}");

//Вариант2
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine($"Рандомное число = {digits}");

int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:secondNumber;
Console.WriteLine($"Максимально число = {resultNumber}");

//Вариант 3
