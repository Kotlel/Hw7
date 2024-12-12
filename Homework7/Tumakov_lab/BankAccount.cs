using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_lab8
{
        class BankAccount
        {
            private static int accountNumCounter = 0;
            private int accountNum;
            private decimal balance;
            private AccountType accountType;
            public BankAccount(decimal balance, AccountType accountType)
            {
                if (balance >= 0)
                {
                    this.accountNum = accountNumCounter++;
                    this.balance = balance;
                    this.accountType = accountType;
                }
                else { Console.WriteLine("Введите баланс правильно"); }
            }

        public string GetFullInfo()
        {
            return $"Номер счёта {accountNum}, Баланс {balance}, Тип счёта {accountType}";
        }
        public void MoneyTransfer( BankAccount bankAccount, decimal amount )
        {
            if ( amount <= 0)
            {
                Console.WriteLine("Сумма перевода должна быть положительной");
            }
            else if ( balance >= amount )
            {
                this.balance -= amount;
                bankAccount.balance  += amount;
                Console.WriteLine("Сумма успешно переведена");
            }
            else
            {
                Console.WriteLine("Недостаточно средств для перевода");
            }
        }
        }
  
}
