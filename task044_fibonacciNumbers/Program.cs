void FibonacciSequence(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(".");
}

Console.WriteLine("Сколько чисел последовательности Фибоначчи вывести?");
int n = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = new int[n];
fibonacci[1] = 1;
Console.Write($"Последовательность Фибоначчи до {n}: {fibonacci[0]}, {fibonacci[1]}");
if (n > 2)
{
    Console.Write(", ");
}

FibonacciSequence(fibonacci);
Console.ReadLine();