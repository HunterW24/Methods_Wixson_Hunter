using System;

class Program
{
    static void Main(string[] args)
    {
        // Multiplication method
        int result = Multiply(5, 7);
        Console.WriteLine($"Multiplication result: {result}");

        // Welcome method
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Welcome(userName);

        // Farewell method
        Farewell();

        // Have a fantastic day
        HaveFantasticDay();
    }

    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    static void Welcome(string name)
    {
        Console.WriteLine($"Hello, {name}! It is nice to meet you!");
    }

    static void Farewell()
    {
        Console.WriteLine("Goodbye! Have a great day!");
    }

    static void HaveFantasticDay()
    {
        Console.WriteLine("Have a fantastic day!");
    }
}