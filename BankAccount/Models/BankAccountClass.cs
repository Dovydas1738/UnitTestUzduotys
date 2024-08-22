namespace BankAccount.Models
{
    public class BankAccountClass : IBankAccount
    {
        decimal Balance = 0;

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                throw new Exception("Balance is not sufficient");
            }
            else
            {
                Balance -= amount;
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }

    public interface IBankAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
    }
}
