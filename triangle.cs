using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the diamond: ");
        int rows = int.Parse(Console.ReadLine());

        
        for (int i = 1; i <= rows; i++)
        {
           
            Console.Write(new string(' ', rows - i));
            
            Console.WriteLine(new string('*', 2 * i - 1));
        }

        
        for (int i = rows - 1; i >= 1; i--)
        {
        
            Console.Write(new string(' ', rows - i));
          
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}
