using System;
using NUnit.Framework;
using BankAccountNS;

namespace BankTests
{
    [TestFixture]
    public class BankAccountTests
    {
        /* Метод теста должен удовлетворять следующим требованиям:

        Он декорируется атрибутом [Test].

        Он возвращает void.

        Он не должен иметь параметров. */
        
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99; // стартовый баланс
            double debitAmount = 4.55; // сколько снять со счета
            double expected = 7.44; // ожидаемое значение
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance); //инициализируем новый аккаунт

            // Act
            account.Debit(debitAmount); // выполняем метод дебет (снимаем деньги)

            // Assert
            double actual = account.Balance; // получаем актуальный баланс
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly"); // если разница есть, то ошибка
        }
    }
}