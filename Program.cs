// See https://aka.ms/new-console-template for more information
using System;

public class ConsoleApp1
{
    public static void Main(string[] args)
    {
        // Greeting and Direct Input
        Console.WriteLine("Welcome to the C# ATM!");
       /* Console.WriteLine("Which name do you wish to use?");
        Console.WriteLine("Jeff, Bill, Sally, or Catherine");
        Console.WriteLine("Please type your answer"); */
       // string name = Console.ReadLine();
        User client = new User();
        Console.WriteLine("Enter UserName");
        string userName = Console.ReadLine();
        client.Name = userName;
        Console.WriteLine("Welome " + userName + " what action would you like to perform today?");
      /*  switch (name)
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
        } */
        Console.WriteLine("Choose an action:");
        Console.WriteLine("Check Balance");
        Console.WriteLine("Make a deposit");
        Console.WriteLine("Make a withdrawal");
        string action = Console.ReadLine();

        BankAccount bankAccount = new BankAccount();
        switch (action)
        {
            case "Check Balance":
                bankAccount.checkBalance();
                break;
            case "Make a deposit":
                Console.WriteLine("Enter how much you would like to deposit?");
                int inputDeposit = Convert.ToInt32(Console.Read());
                bankAccount.deposit(inputDeposit);
                break;
            case "Make a withdrawal":
                Console.WriteLine("Enter how much you would like to withdraw?");
                int inputWithdrawal = Convert.ToInt32(Console.Read());
                bankAccount.withdrawal(inputWithdrawal);
                break;
        }
        bool decision = true;
        while (decision == true)
        {
            Console.WriteLine("Would you like to perform another action?");
            string response = Console.ReadLine();
            if (response == "yes" || response == "Yes" || response == "YES")
            {
                decision = true;
                Console.WriteLine("Choose an action:");
                Console.WriteLine("Check Balance");
                Console.WriteLine("Make a deposit");
                Console.WriteLine("Make a withdrawal");
                action = Console.ReadLine();
                switch (action)
                {
                    case "Check Balance":
                        bankAccount.checkBalance();
                        break;
                    case "Make a deposit":
                        Console.WriteLine("Enter how much you would like to deposit?");
                        int inputDeposit = Convert.ToInt32(Console.Read());
                        bankAccount.deposit(inputDeposit);
                        break;
                    case "Make a withdrawal":
                        Console.WriteLine("Enter how much you would like to withdraw?");
                        int inputWithdrawal = Convert.ToInt32(Console.Read());
                        bankAccount.withdrawal(inputWithdrawal);
                        break;
                    
                }
            }
            else
            {
                decision = false;
            }
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
        private double balance = 0;
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

