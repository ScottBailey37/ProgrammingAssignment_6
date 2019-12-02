/* CODE OF HONOR: I have not discussed the source code in my program with anyone other than my 
 * instructor’s approved human sources. I have not used source code obtained from another student, 
 * or any other unauthorized source, either modified or unmodified. If any source code or documentation 
 * used in my program was obtained from another source, such as a textbook or course notes, that 
 * has been clearly noted with a proper citation in the comments of my program. I have not knowingly 
 * designed this program in such a way as to defeat or interfere with the normal operation of any 
 * machine it is graded on or to produce apparently correct results when in fact it does not. */

using System;

namespace ProgrammingAssignment_6
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            // Create and initialize new checking account object 
            CheckingAccount checkingAccount = new CheckingAccount("Bailey-Checking", 1, 1000, 3);
            Console.WriteLine("Created checking account with $1,000 balance.");

            // Create and initialize new savings account object
            SavingsAccount savingsAccount = new SavingsAccount("Bailey-Savings", 2, 2000, .05);
            Console.WriteLine("Created savings account with $2,000 balance.\n");

            // Print initial account data
            checkingAccount.PrintAccount();
            savingsAccount.PrintAccount();

            // Deposit into checking
            Console.WriteLine("Deposit $100 into checking.");
            checkingAccount.MethodCredit(100);
            checkingAccount.PrintAccount();

            // Withdraw from checking
            Console.WriteLine("Withdraw $50 from checking.");
            checkingAccount.MethodDebit(50);
            checkingAccount.PrintAccount();

            // Try to overdraw from checking
            Console.WriteLine("Withdraw $6,000 from checking.");
            checkingAccount.MethodDebit(6000);
            checkingAccount.PrintAccount();

            // Deposit into savings
            Console.WriteLine("Deposit $3,000 into savings.");
            savingsAccount.MethodCredit(3000);
            savingsAccount.PrintAccount();

            // Withdraw from savings
            Console.WriteLine("Withdraw $200 from savings.");
            savingsAccount.MethodDebit(200);
            savingsAccount.PrintAccount();

            // Calculate interest earned on savings and credit account
            Console.WriteLine("Calculate Interest on savings.");            
            savingsAccount.MethodCredit(savingsAccount.CalculateInterest());
            savingsAccount.PrintAccount();

            // Try to overdraw from savings
            Console.WriteLine("Withdraw $10,000 from savings.");
            savingsAccount.MethodDebit(10000);
            savingsAccount.PrintAccount();

            // Wait for user to press the enter key before exiting
            Console.WriteLine("\nPress the [Enter] key to continue.");
            // Intercept all other keys except enter key
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
