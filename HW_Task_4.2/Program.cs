// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Insert number number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number);

int sum = 0;

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine($" -> {sum}");


