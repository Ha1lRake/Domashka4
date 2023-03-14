// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12




Console.WriteLine("Введите число");

var x = Console.ReadLine();

int number = Convert.ToInt32(x);

int len = x.Length;

int sum = 0;

for(int i = 0; i<=len; i++)
{
    

    sum = sum + number % 10;

    number /=  10;

}




Console.WriteLine(sum);