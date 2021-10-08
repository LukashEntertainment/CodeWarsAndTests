using System;
namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName // возвращает имя
        {
            get { return m_customerName; }
        }

        public double Balance // возвращает баланс
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance) //кол-во для снятия денег не должно быть больше текущего кол-ва на счету
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount; // intentionally incorrect code, должен быть вычет из баланса
        }

        public void Credit(double amount) //пополнение счета
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77); // пополнение счета на 5.77 единиц валюты
            ba.Debit(11.22); // по логике - вычет 11.22 единиц, но из-за ошибки в коде будет пополнение
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}