void FibonacciSequence()
{
    Console.WriteLine("Сколько чисел последовательности Фибоначчи надо?");
    int howMany = Convert.ToInt32(Console.ReadLine());
            
    Console.Write("Последовательность Фибоначчи: ");
            
    int result;
    int firstNumber = 0;
    int secondNumber = 1;
    if (howMany <= 1)
    {
        Console.Write(firstNumber);
    }
    else if (howMany == 2)
    {
        Console.Write(firstNumber + ", ");
        Console.Write(secondNumber);
    }
    else
    {
        Console.Write(firstNumber + ", ");
        Console.Write(secondNumber + ", ");
        for (int i = 3; i <= howMany; i++)
        {
            result = firstNumber + secondNumber;
            Console.Write(result);
            firstNumber = secondNumber;
            secondNumber = result;
            if (i != howMany)
            {
                Console.Write(", ");
            }
        }
    }
    Console.Write(".");
}
        
FibonacciSequence();
Console.ReadLine();