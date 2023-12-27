using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        string[] myArray = new string[size];

       
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element at index {i}: ");
            myArray[i] = Console.ReadLine();
        }

        
        for (int i = 0; i < myArray.Length; i++)
        {
            int letterCount = 0;
            int numberCount = 0;

            
            for (int j = 0; j < myArray[i].Length; j++)
            {
                
                if (IsLetter(myArray[i][j]))
                {
                    letterCount++;
                }
                
                else if (IsNumber(myArray[i][j]))
                {
                    numberCount++;
                }
            }

            
            if (letterCount > 0 && numberCount > 0)
            {
                Console.WriteLine(myArray[i]);
                

            }
        }
        Console.ReadKey();
    }

    
    static bool IsLetter(char c)
    {
        return char.IsLetter(c);
    }

    static bool IsNumber(char c)
    {
        return char.IsDigit(c);
    }
}
