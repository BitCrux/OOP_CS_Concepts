using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example2.Models
{
    public class RedState : Abstracts.State
    {
        private double serviceFee;
        // Constructor
        public RedState(Abstracts.State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }
        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            serviceFee = 15.00;
        }
        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        public override void Withdraw(double amount)
        {
            amount = amount - serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }
        public override void PayInterest()
        {
            // No interest is paid
        }
        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
