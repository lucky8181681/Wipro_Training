using System;

class PatternMatchingDemo
{
    static void Main()
    {
        Console.WriteLine("Enter a value:");
        string input = Console.ReadLine();
        object value;                                        // Convert input into proper type (important fix)
        if (int.TryParse(input, out int i))
            value = i;
        else if (double.TryParse(input, out double d))
            value = d;
        else
            value = input;

        switch (value)                                       // Pattern matching using switch
        {
            case int num:
                Console.WriteLine($"Integer detected: {num}");
                break;

            case double dbl:
                Console.WriteLine($"Double detected: {dbl}");
                break;

            case string str:
                Console.WriteLine($"String detected: {str}");
                break;

            default:
                Console.WriteLine("Unknown type");
                break;
        }



        var point = (x: 10, y: 20);                           //  Pattern matching with Tuple

        if (point is (var x, var y))
        {
            Console.WriteLine($"Tuple values -> X: {x}, Y: {y}");
        }

        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Age:");
        int age = int.Parse(Console.ReadLine());

        var person = new Person { Name = name, Age = age }; // Pattern matching with Properties

        if (person is { Age: > 18 })
        {
            Console.WriteLine($"{person.Name} is Adult");
        }
        else
        {
            Console.WriteLine($"{person.Name} is Minor");
        }
    }
}
class Person                                                  // Class for property pattern
{
    public string Name { get; set; }
    public int Age { get; set; }
}