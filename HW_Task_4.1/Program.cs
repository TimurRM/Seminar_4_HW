// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int numberPow(int A, int B){

    int pow = 1;
    for (int i = 1; i <= B; i++){
    pow *= A;
    }
    return pow;
}

Console.Write("Insert number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int numPow = numberPow(A, B);

Console.WriteLine($"{A},{B} -> {numPow}");

System.Console.WriteLine("--------------------");





void PowNumber()
{
        // Console.Write("Insert number numA: ");
        // int numA = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Insert number numB: ");
        // int numB = Convert.ToInt32(Console.ReadLine());

        int numA = new Random().Next(10);
        int numB = new Random().Next(10);

        Console.WriteLine("{0}, {1} -> " + Math.Pow(numA, numB), numA, numB);
        
    }
    for (int i = 0; i < 3; i++)
    {
            PowNumber();
}
