using System;
using System.Collections.Generic;

class Order
{
    public int OrderId;
    public string ProductName;
    public double Price;
}

class Customer
{
    public int CustomerId;
    public string Name;
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>();
        Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
        HashSet<string> categories = new HashSet<string>();
        Queue<Order> orderQueue = new Queue<Order>();
        Stack<string> orderHistory = new Stack<string>();

        Console.Write("Enter number of customers: ");
        int c = int.Parse(Console.ReadLine());

        for (int i = 0; i < c; i++)
        {
            Console.WriteLine($"\nEnter Customer {i + 1} details:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            customers[id] = new Customer { CustomerId = id, Name = name };
        }

        Console.Write("\nEnter number of orders: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter Order {i + 1} details:");

            Order o = new Order();

            Console.Write("Order ID: ");
            o.OrderId = int.Parse(Console.ReadLine());

            Console.Write("Product Name: ");
            o.ProductName = Console.ReadLine();

            Console.Write("Price: ");
            o.Price = double.Parse(Console.ReadLine());

            orders.Add(o);

            Console.Write("Enter Category: ");
            categories.Add(Console.ReadLine());

            orderQueue.Enqueue(o);

            // Status tracking
            orderHistory.Push($"Order {o.OrderId} Created");
        }

        // Update
        Console.Write("\nEnter Order ID to update: ");
        int updateId = int.Parse(Console.ReadLine());

        foreach (var o in orders)
        {
            if (o.OrderId == updateId)
            {
                Console.Write("Enter new price: ");
                o.Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Order Updated");
            }
        }

        // Remove
        Console.Write("\nEnter Order ID to remove: ");
        int removeId = int.Parse(Console.ReadLine());

        orders.RemoveAll(o => o.OrderId == removeId);

        // Processing
        Console.WriteLine("\nProcessing Orders:");
        while (orderQueue.Count > 0)
        {
            var current = orderQueue.Dequeue();
            Console.WriteLine($"Processing Order {current.OrderId}");

            orderHistory.Push($"Order {current.OrderId} Processing");
            orderHistory.Push($"Order {current.OrderId} Shipped");
        }

        // Display history
        Console.WriteLine("\nOrder Status History:");
        foreach (var h in orderHistory)
        {
            Console.WriteLine(h);
        }

        // Display customers
        Console.WriteLine("\nCustomers:");
        foreach (var cst in customers)
        {
            Console.WriteLine($"ID: {cst.Key}, Name: {cst.Value.Name}");
        }

        // Display categories
        Console.WriteLine("\nUnique Categories:");
        foreach (var cat in categories)
        {
            Console.WriteLine(cat);
        }
    }
}