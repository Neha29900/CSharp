using System;

class Program
{
    static void Main()
    {
        string mainString = "Hello, welcome to the world of C#!";
        string searchString = "world";

        // Find the index of the searchString in mainString
        int index = mainString.IndexOf(searchString);

        if (index != -1)
        {
            Console.WriteLine($"The substring '{searchString}' was found at index {index}.");
        }
        else
        {
            Console.WriteLine($"The substring '{searchString}' was not found.");
        }
    }
}
