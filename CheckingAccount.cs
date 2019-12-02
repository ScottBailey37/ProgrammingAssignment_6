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
    class CheckingAccount : Account
    {
        // Declare private variable
        private decimal FeeCharged; // Transaction fee

        /// <summary>
        /// Initializes a new instance of the CheckingAccount class using the supplied values.
        /// Calls the base class constructor to initialize the account name, number, and initial balance.
        /// </summary>
        /// <param name="name">The name of the account.</param>
        /// <param name="accountnumber">The number of the account.</param>
        /// <param name="initialbalance">The initial balance of the account.</param>
        /// <param name="feecharged">The fee charged for transactions.</param>
        public CheckingAccount(string name, int accountnumber, decimal initialbalance, decimal feecharged) 
            : base(name, accountnumber, initialbalance)
        {
            // Initialize the transaction fee of the account
            setFeeAmount(feecharged);
        }

        /// <summary>
        /// Sets the transaction fee of the account.
        /// </summary>
        /// <param name="feecharged">The transaction fee to set.</param>
        public void setFeeAmount(decimal feecharged)
        {
            // No negative values
            if (feecharged >= 0.0M)
            {
                // Initialize the account transaction fee
                this.FeeCharged = feecharged;
            }
            else // Fee was negative
            {
                // Just set to zero
                this.FeeCharged = 0.0M;
            }
        }

        /// <summary>
        /// Credits the account and updates the balance. (Hides base method)
        /// </summary>
        /// <param name="amount">The amount to credit.</param>
        new public void MethodCredit(decimal amount)
        {
            base.MethodCredit(amount);
            base.MethodDebit(this.FeeCharged);
        }

        /// <summary>
        /// Debits the account and updates the balance. (Hides base method)
        /// </summary>
        /// <param name="amount">The amount to deduct.</param>
        new public void MethodDebit(decimal amount)
        {
            // Is withdraw successful?
            if (base.MethodDebit(amount))
            {
                // Withdrawn successfully
                // So, subtract the fee from the balance
                base.MethodDebit(this.FeeCharged);
            }            
        }

        /// <summary>
        /// Prints the account information. (Overrides base class PrintAccount())
        /// </summary>
        public override void PrintAccount()
        {
            // Invoke base class PrintAccount() method
            base.PrintAccount();

            // Also, print the transaction fee charged for this account 
            Console.WriteLine("Fee charged: " + this.FeeCharged.ToString("C") + "\n");
        }
    }
}
