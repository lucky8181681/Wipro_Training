using System;
using System.Collections.Generic;

class Transaction
{
    public string Id;
    public string Type; // deposit / withdraw
    public double Amount;
}

class Program
{
    static void Main()
    {
        List<Transaction> history = new List<Transaction>();
        Dictionary<string, double> accounts = new Dictionary<string, double>();
        Queue<Transaction> pending = new Queue<Transaction>();
        Stack<Transaction> rollback = new Stack<Transaction>();
        HashSet<string> transactionIds = new HashSet<string>();

        // Account setup
        Console.Write("Enter Account ID: ");
        string accId = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        double balance = double.Parse(Console.ReadLine());

        accounts[accId] = balance;

        // Transactions input
        Console.Write("\nEnter number of transactions: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nTransaction {i + 1}:");

            Console.Write("Enter Transaction ID: ");
            string tId = Console.ReadLine();

            if (!transactionIds.Add(tId))
            {
                Console.WriteLine("Duplicate Transaction ID! Skipping...");
                continue;
            }

            Console.Write("Enter Type (deposit/withdraw): ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter Amount: ");
            double amt = double.Parse(Console.ReadLine());

            if (type == "withdraw")
                amt = -amt;

            pending.Enqueue(new Transaction
            {
                Id = tId,
                Type = type,
                Amount = amt
            });
        }

        // Process transactions
        Console.WriteLine("\nProcessing Transactions:");
        while (pending.Count > 0)
        {
            Transaction t = pending.Dequeue();

            if (accounts[accId] + t.Amount < 0)
            {
                Console.WriteLine($"Transaction {t.Id} failed (Insufficient balance)");
                continue;
            }

            accounts[accId] += t.Amount;
            history.Add(t);
            rollback.Push(t);

            Console.WriteLine($"Transaction {t.Id} ({t.Type}) successful. Balance: {accounts[accId]}");
        }

        // Rollback
        Console.Write("\nDo you want to rollback last transaction? (yes/no): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "yes" && rollback.Count > 0)
        {
            Transaction last = rollback.Pop();

            accounts[accId] -= last.Amount;
            history.Remove(last);

            Console.WriteLine($"Rolled back Transaction {last.Id}. New Balance: {accounts[accId]}");
        }

        // Display history
        Console.WriteLine("\nTransaction History:");
        foreach (var t in history)
        {
            Console.WriteLine($"{t.Id} - {t.Type} - {Math.Abs(t.Amount)}");
        }

        // Final balance
        Console.WriteLine($"\nFinal Balance: {accounts[accId]}");
    }
}