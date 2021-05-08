using System;




namespace ATM_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial variables
            double accountBalance, withdrawal, bankFees, newAccountBalance;
            //setting initial balance to $500
            accountBalance = 500.00d;
            //decaring a bool variable for more transactions
            bool moreTransactions = true;

            //while loop for more transactions
            while (moreTransactions)
            {
                chooseAmount:
                try
                {
                    Console.WriteLine("Enter the amount you wish to withdraw in multiples of 5: ");

                    withdrawal = Convert.ToDouble(Console.ReadLine());
                    bankFees = +0.50d;
                    newAccountBalance = accountBalance - withdrawal - bankFees;

                    if (withdrawal >= accountBalance)
                    {
                        Console.WriteLine("insufficent fund in account balance");
                    }

                    else if (withdrawal % 5 == 0)
                    {
                        Console.WriteLine("Successful operation!");
                        Console.WriteLine("Your Balance after your operation is : $" + newAccountBalance);
                        accountBalance = newAccountBalance;
                    }
                    else if (withdrawal % 5 != 0)
                    {
                        Console.WriteLine("Please enter a correct amount in multiples of 5: ");
                        Console.ReadLine();
                        Console.WriteLine("Your Balance after your transaction is : $" + newAccountBalance);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect amount!");
                    goto chooseAmount;
                }
                
             continue1:
             Console.WriteLine("Would you like to conduct another transaction? (Y/N)");
             string ans = Console.ReadLine().ToUpper();

                if (ans == "N")
                {
                    moreTransactions = false;
                    Console.WriteLine("Thanks for using our ATM! Have a nice day!");
                }
                else if (ans == "Y")
                {
                    moreTransactions = true;
                }
                else
                {
                    Console.WriteLine("Please enter 'Y' for Yes or 'N' for No:");
                    goto continue1;
                }
            
            }
            
        }
    }
}

