void FibonacciSequence(int[] array)
        {
            if(array.Length < 1)
            {
                Console.WriteLine("Ну и что ты тут хочешь увидеть, умник?");
            }
            
            else if (array.Length == 1)
            {
                array[0] = 0;
                Console.Write(array[0]);
            }
            else
            {
                for (int index = 0; index < 2; index++)
                {
                    array[index] = index;
                    Console.Write(array[index]);
                    if (index != 1)
                    {
                        Console.Write(", ");
                    }
                }
                if (array.Length > 2)
                {
                    Console.Write(", ");
                }
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
        }
            
        Console.WriteLine("Сколько чисел последовательности Фибоначчи надо?");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] fibonacci = new int[n];
        Console.Write($"Последовательность Фибоначчи от 1 до {n}: ");
        
        FibonacciSequence(fibonacci);
        Console.ReadLine();