using System;
using System.Collections.Generic;
using System.Text;

namespace Qcrotty_Exercise6
{
    public class BankAcc
    {
        public decimal Balance { get; set; }
              
        public List<decimal> Transactions
        {
            get { return transactions; } set { transactions = value; }  
            
        }

                  

        private List<decimal> transactions = new List<decimal>();
                                                              
        public enum AccStatus
        {
            Successful,Overdrawn,Insufficient_Funds,Deposit_Too_Large
        }

        public AccStatus Deposit(decimal accBal, decimal deposit)
        {
            if (deposit > 10_000)
            {
                return AccStatus.Deposit_Too_Large;
            }
            accBal += deposit;
            Balance = accBal;
            Transactions.Add(Balance);
            return AccStatus.Successful;
        }

        public AccStatus Withdrawal(decimal accBal, decimal withdrawal)
        {
            accBal -= withdrawal;
            if(accBal < 0)
            {
                accBal -= 35.75m;
                if(accBal < -100)
                {
                    accBal += 35.75m;
                    Balance = accBal + withdrawal;
                    Transactions.Add(Balance);
                    return AccStatus.Insufficient_Funds;
                }
                Balance = accBal;
                Transactions.Add(Balance);
                return AccStatus.Overdrawn;
            }
            Balance = accBal;
            Transactions.Add(Balance);
            return AccStatus.Successful;
        }

        public String AccountStatus(int AccStatus)
        {
            String output = "";
            switch (AccStatus)
            {
                case 0:
                    output = "There are no problems with your account.";
                    return output;
                case 1:
                    output = "Your account is overdrawn.  Please make a deposit.";
                    return output;
                case 2:
                    output = "You have insufficent funds for your current transaction.";
                    return output;
                case 3:
                    output = "You cannot deposit an amount greater than $10,000.00";
                    return output;
            }
            return output;
        }

        public decimal GetAccountBalance()
        {
            return Balance;
        }

    }
}
