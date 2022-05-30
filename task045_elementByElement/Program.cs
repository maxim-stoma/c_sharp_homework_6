void SetArray(int[] variety)
{
    for (int index = 0; index < variety.Length; index++)
    {
        variety[index] = new Random().Next(-100, 100);
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
}
        
void ElementByElementCopying(int[] pile, int[] group)
{
    Console.Write("[ ");
    for (int i = 0; i < pile.Length; i++)
    {
        group[i] = pile[i];
        Console.Write(group[i]);
        if (i != pile.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}
        
Console.Write("Введи размер массива...ну, сколько чисел надо: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] arrayCopy = new int[size];
        
SetArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Скопированный поэлементно массив выглядит так: ");
        
ElementByElementCopying(array, arrayCopy);
        
Console.ReadLine();