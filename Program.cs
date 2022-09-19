//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* Console.WriteLine ("Введите числа через пробел ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0: {count}"); */

// Задача 43.Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = double.Parse(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"точка пересечеия двух прямых X: {x}, Y: {y}");
