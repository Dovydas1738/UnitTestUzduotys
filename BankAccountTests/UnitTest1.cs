using BankAccount.Models;
using System.Buffers;

namespace BankAccountTests
{
    public class UnitTest1
    {
        [Fact]
        public void DepositTest()
        {
            IBankAccount operations = new BankAccountClass();
            decimal amount = 100;
            decimal result = 100;

            operations.Deposit(amount);

            Assert.Equal(result, operations.GetBalance());

        }
        [Fact]
        public void WithdrawTest()
        {
            IBankAccount operations = new BankAccountClass();
            decimal amount = 100;
            decimal amount2 = 50;
            decimal result = 50;

            operations.Deposit(amount);
            operations.Withdraw(amount2);

            Assert.Equal(result, operations.GetBalance());
        }

        [Fact]
        public void BalanceTest()
        {
            IBankAccount operations = new BankAccountClass();
            decimal amount = 100;
            decimal amount2 = 50;
            decimal result = 150;

            operations.Deposit(amount);
            operations.Deposit(amount2);

            Assert.Equal(result, operations.GetBalance());
        }

        [Fact]
        public void BalanceExTest()
        {
            IBankAccount operations = new BankAccountClass();
            decimal amount = 50;
            decimal amount2 = 100;

            operations.Deposit(amount);

            Assert.Throws<Exception>(()=> operations.Withdraw(amount2));
        }
    }
}