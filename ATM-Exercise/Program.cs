using System;

namespace ATM_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double accountBalance, withdrawal, bankFees, newAccountBalance;
            accountBalance = 500.00d;
            bool moreTransactions = true;
           
            while (moreTransactions)
            {
                try
                {
                    Console.WriteLine("Enter the amount you wish to withdraw: ");

                    withdrawal = Convert.ToDouble(Console.ReadLine());
                    bankFees = +0.50d;
                    newAccountBalance = accountBalance - withdrawal - bankFees;
                   
                    if (withdrawal > accountBalance)
                    {
                        Console.WriteLine("insufficent fund in account balance");
                    }

                    else if (withdrawal % 5 == 0)
                    {
                        Console.WriteLine("Your Balance after your operation is : $" + newAccountBalance);
                        accountBalance = newAccountBalance;
                    }
                    else if (withdrawal % 5 != 0)
                    {
                        Console.WriteLine("Please enter a correct amount: ");
                        Console.ReadLine();
                        Console.WriteLine("Your Balance after your operation is : $" + newAccountBalance);
                    }
                    Console.WriteLine("Would you like to conduct another transaction? (Y/N)");
                    string ans = Console.ReadLine().ToUpper();
                    if (ans == "N")
                        moreTransactions = false;
                    else
                    {
                        Console.WriteLine("Please enter dollar amount in multiples of 5: ");
                    }
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter dollar amount in multiples of 5: ");

                    Console.WriteLine("Would you like to conduct another transaction? (Y/N)");
                    string ans = Console.ReadLine().ToUpper();
                    if (ans == "N")
                        moreTransactions = false;

                    else 
                    {
                        Console.WriteLine("Please enter dollar amount in multiples of 5: ");
                    }
                    
                }
                
            }
            
        }
    }
}

