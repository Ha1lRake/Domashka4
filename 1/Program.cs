// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
int result = x;

for(int i = 1; i < y; i++)
{
    result = result * x ;
    
}
Console.WriteLine($"Число {x} в степени {y} равно {result}");