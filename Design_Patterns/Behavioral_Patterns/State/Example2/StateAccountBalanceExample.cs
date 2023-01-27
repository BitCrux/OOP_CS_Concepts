using Design_Patterns.Behavioral_Patterns.State.Example2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example2
{
    //This real-world code demonstrates the State pattern which allows an Account to behave differently
    //depending on its balance. The difference in behavior is delegated to State objects called
    //RedState, SilverState and GoldState. These states represent overdrawn accounts, starter accounts, and
    //accounts in good standing.
    public class StateAccountBalanceExample
    {
        public void Run()
        {
            // Open a new account
            Account account = new Account("Jim Johnson");
            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            // Wait for user
            Console.ReadKey();
        }
    }
}
