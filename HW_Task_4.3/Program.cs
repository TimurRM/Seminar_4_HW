// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] CreateRandomArray(int start, int end)
{
    int[] RandomArray = new int[8];
    for (int i = 0; i < 8; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
         if (i < 7)
            {
            Console.Write(RandomArray[i] + ", ");    
            }
        else
            {
            Console.Write(RandomArray[i]);
            }
        
    }
    return RandomArray;
}


void ShowArray(int[] array)

{Console.Write(" -> [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1)
            {
            Console.Write(array[i] + ", ");    
            }
        else
            {
            Console.Write(array[i]);
            }
        
    }
    Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(min, max);
ShowArray(myRandomArray);


