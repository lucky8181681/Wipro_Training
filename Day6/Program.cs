using System;

class Program
{
    static void Main(string[] args)
    {
        MathOperation op = DelegateDemo.Add;
        int result = op(10, 5);
        Console.WriteLine("Addition: " + result);

        op = DelegateDemo.Subtract;
        result = op(10, 5);
        Console.WriteLine("Subtraction: " + result);

        op = DelegateDemo.Multiply;
        result = op(10, 5);
        Console.WriteLine("Multiplication: " + result);

        op = DelegateDemo.Divide;
        result = op(20, 5);
        Console.WriteLine("Division: " + result);
    }
}