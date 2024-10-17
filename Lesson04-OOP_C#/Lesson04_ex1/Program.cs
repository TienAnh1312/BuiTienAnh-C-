namespace Lesson04_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo tài khoản SavingAccount
            SavingAccount savingAccount = new SavingAccount(1000, 0.05);
            savingAccount.Deposit(500);
            Console.WriteLine($"Số tiền lãi: {savingAccount.GetInterest()}");
            savingAccount.Withdraw(300);
            Console.WriteLine($"Số dư cuối cùng: {savingAccount.GetBalance()}");

            // Tạo tài khoản CheckAccount
            CheckAccount checkAccount = new CheckAccount(1000, 5);
            checkAccount.Deposit(300);
            checkAccount.Withdraw(200);
            Console.WriteLine($"Số dư cuối cùng: {checkAccount.GetBalance()}");
        }
    }
}
