using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        int num1 = 10;
        int num2 = 20;
        int sum = num1 + num2;
        Console.WriteLine("Sum is: " + sum);

        Console.Write("Enter something: ");
        string input = Console.ReadLine();

        Console.WriteLine("You entered: " + input);

        Console.ReadLine();
    }
}
