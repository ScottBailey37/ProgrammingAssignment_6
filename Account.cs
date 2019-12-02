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
    class Account
    {

        // Declare private variables
        private decimal Balance;
        private string AccountName = "";
        private int AccountNumber;

        /// <summary>
        /// Initializes a new instance of the Account class using the supplied values.
        /// </summary>
        /// <param name="name">The name of the account.</param>
        /// <param name="accountnumber">The number of the account.</param>
        /// <param name="initialbalance">The initial balance of the account.</param>
        public Account(string name, int accountnumber, decimal initialbalance)
        {
            setAccountName(name);
            setAccountNumber(accountnumber);
            setBalance(initialbalance);
        }

        /// <summary>
        /// Sets the name of the account.
        /// </summary>
        /// <param name="name">The name to set account name to.</param>
        public void setAccountName(string name)
        {
            // Initialize the account name
            this.AccountName = name;
        }

        /// <summary>
        /// Sets the account number.
        /// </summary>
        /// <param name="accountnumber">The number to set account number to.</param>
        public void setAccountNumber(int accountnumber)
        {
            // Initialize account number
            this.AccountNumber = accountnumber;
        }

        /// <summary>
        /// Sets the initial balance of the account.
        /// </summary>
        /// <param name="balance">The amount to set account balance to.</param>
        public void setBalance(decimal amount)
        {
            // No negative numbers
            if (amount >= 0.0M) 
            {
                // Initialize account balance
                this.Balance = amount;

            }else// Otherwise
            {
                this.Balance = 0;
            }
        } 

        /// <summary>
        /// Gets the account name.
        /// </summary>
        /// <returns></returns>
        public string getAccountName()
        {
            return this.AccountName;
        }

        /// <summary>
        /// Gets the account number.
        /// </summary>
        /// <returns></returns>
        public int getAccountNumber()
        {
            return this.AccountNumber;
        }

        /// <summary>
        /// Gets the account balance.
        /// </summary>
        /// <returns></returns>
        public decimal getBalance()
        {
            return this.Balance;             
        }

        /// <summary>
        /// Credits the account and updates the balance. (Overridable)
        /// </summary>
        /// <param name="amount">The amount to credit to the account.</param>
        public virtual void MethodCredit(decimal amount)
        {
            // Credit the account balance
            this.Balance += amount;
        }

        /// <summary>
        /// Debits the account and updates the balance. (Overridable)
        /// </summary>
        /// <param name="amount">The amount to deduct.</param>
        /// <returns>True if successful, otherwise false.</returns>
        public virtual bool MethodDebit(decimal amount)
        {
            // Can't be more than the balance (No overdraft privilege)
            if (amount <= this.Balance)
            {
                // Money needs to be withdrawn
                this.Balance = (this.Balance - amount);
                return true; // Successful withdraw
            }
            else
            {
                Console.WriteLine("Insufficient Funds.");
                return false; // Unsuccessful withdraw
            }            
        }

        /// <summary>
        /// Prints account information. (Overridable)
        /// </summary>
        public virtual void PrintAccount()
        {
            // Print account name, number, and balance each on a separate line
            Console.WriteLine("Account Name: " + this.AccountName + "\nAccount Number: " + this.AccountNumber + "\nBalance: " + this.Balance.ToString("C"));
        }
    }
}
