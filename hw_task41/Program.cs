/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();

Console.WriteLine("Введите размерность массива:");
int dimensionArray = Convert.ToInt32(Console.ReadLine());
int [] userArray = new int[dimensionArray];

Console.WriteLine();

PrintArray (userArray);

int sumPositive = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray [i] > 0)
        {
            sumPositive = sumPositive + 1;
        }
    }
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 равно {sumPositive}");


void PrintArray (int [] userArray)
    {
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < userArray.Length; i++)
            {
                userArray [i] = Convert.ToInt32(Console.ReadLine());
            }
    }