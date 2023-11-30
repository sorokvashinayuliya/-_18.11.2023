using System;
using System.Collections.Generic;

namespace ДЗ_18._11._2023
{
    internal class BankAccountFactory
    {
        public decimal AccountBalance { get; private set; }
        public int AccountNumber { get; private set; }
        internal BankAccountFactory(decimal initialAccountBalance, int accountNumber)
        {
            AccountBalance = initialAccountBalance;
            AccountNumber = accountNumber;
        }
        internal class BankAccount
        {
            readonly Dictionary<int, BankAccount> bankAccounts = new Dictionary<int, BankAccount>();
            internal int CreateAccount(int accountNumber, int accountBalance)
            {

                BankAccount account = new BankAccountFactory(accountNumber, accountBalance);
                bankAccounts.Add(accountNumber, account);
                return accountNumber;
            }
            internal void DeleteAccount(int accountNumber)
            {
                bankAccounts.Remove(accountNumber);
            }

            public static implicit operator BankAccount(BankAccountFactory v)
            {
                throw new NotImplementedException();
            }
        }

    }
}
