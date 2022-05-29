void SetArray(int[] variety)
{
    for (int index = 0; index < variety.Length; index++)
    {
        Console.Write($"Введи {index} элемент массива: ");
        variety[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] multitude)
{
    Console.Write("[ ");
    for (int pos = 0; pos < multitude.Length; pos++)
    {
        Console.Write(multitude[pos]);

        if (pos != multitude.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}

void PositiveNumberCounter(int[] pile)
{
    int count = 0;

    for (int i = 0; i < pile.Length; i++)
    {
        if (pile[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"В массиве количество положительных чисел равно {count}.");
}

Console.Write("Введи размер массива: ");
int s = Convert.ToInt32(Console.ReadLine()); // переменная s задаёт размер массива
int[] array = new int[s];

SetArray(array);
PrintArray(array);
PositiveNumberCounter(array);

Console.ReadLine();