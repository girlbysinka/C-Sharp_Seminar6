/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
double b1 = PrintNumber();
double k1 = PrintNumber();
double b2 = PrintNumber();
double k2 = PrintNumber();

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if (k1 == k2)

    {
        Console.WriteLine();
        Console.WriteLine($"не пересекаются прямые: y={k1}x+{b1} и y={k2}x+{b2}");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"(x = {x}; y = {y}) - координаты точки пересечения прямых: y={k1}x+{b1} и y={k2}x+{b2}");
    }


int PrintNumber()
    {
    int userNumber = new int();
    Console.WriteLine("Введите число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
    }