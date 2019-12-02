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
    class SavingsAccount : Account
    {
        // Declare private variable
        private double InterestRate;

        /// <summary>
        /// Initializes a new instance of the SavingsAccount class using the supplied values.
        /// Calls the base class constructor to initialize the account name, number, and initial balance.
        /// </summary>
        /// <param name="name">The name of the account.</param>
        /// <param name="accountnumber">The number of the account.</param>
        /// <param name="initialbalance">The initial balance of the account.</param>
        /// <param name="initialrate">The initial interest rate of the account.</param>
        public SavingsAccount(string name, int accountnumber, decimal initialbalance, double initialrate) 
            : base(name, accountnumber, initialbalance)
        {
            // Initialize account interest rate
            setInterestRate(initialrate);
        }

        /// <summary>
        /// Sets the account interest rate.
        /// </summary>
        /// <param name="rate">The interest rate to use.</param>
        public void setInterestRate(double rate)
        {
            // Is rate a positive number?
            if (rate >= 0.0d)
            {
                // Yes, set the interest rate
                this.InterestRate = rate;
            }
            else
            {
                // No, its negative so set it to zero
                this.InterestRate = 0;
            }
        }

        /// <summary>
        /// Calculates the interest accrued on the account.
        /// </summary>
        /// <returns>A decimal value of the total interest accrued.</returns>
        public decimal CalculateInterest()
        {
            // The amount of interest earned by this savings account
            return ((decimal) this.InterestRate * getBalance());
        }

        /// <summary>
        /// Prints the account information. (Overrides base class PrintAccount()).
        /// </summary>
        public override void PrintAccount()
        {
            // Invoke base class PrintAccount() method
            base.PrintAccount();

            // Also, print the interest rate as a percentage of this account
            Console.WriteLine("Interest rate: " + this.InterestRate.ToString("P") + "\n");
        }
    }
}
