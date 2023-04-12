// See https://aka.ms/new-console-template for more information
using System;

public class ConsoleApp1
{
    public static void Main(string[] args)
    {
        // Greeting and Direct Input
        Console.WriteLine("Welcome to the C# ATM!");
        Console.WriteLine("Which name do you wish to use?");
        Console.WriteLine("Jeff, Bill, Sally, or Catherine");
        Console.WriteLine("Please type your answer");
        string name = Console.ReadLine();
        User client = new User();
        switch (name)
        {
            case "Jeff":
                client.Name = "Jeff";
                Console.WriteLine(client.Name);
                break;
            case "Bill":
                Console.WriteLine("Test2");
                break;
            case "Sally":
                Console.WriteLine("Test3");
                break;
            case "Catherine":
                Console.WriteLine("Test4");
                break;
            default:
                Console.WriteLine("Invalid value entered");
                break;
        }
        string action = Console.ReadLine();
        Console.WriteLine("Choose an action:");
        Console.WriteLine("Check Balance");
        Console.WriteLine("Make a Deposit");
        Console.WriteLine("Make a withdrawal");

        switch (action)
        {
            case "Check Balance":
                Console.WriteLine(client.Balance);
                break;


        }
    }
    class User
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; } 
        }
        //public string password { get; set; }
       

    }
    class BankAccount
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void deposit(double input)
        {
            balance += input;
        }
        public void withdrawal(double input)
        {
            balance -= input;
        }
        public void checkBalance()
        {
            Console.WriteLine(balance); //I LOVE YOU SO MUCH <3
        }
    }
}

