using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ex1
{
     abstract class Account
    {
        protected double Balance;

        // Constructor với số tiền ban đầu
        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        // Phương thức gửi tiền
        public void Deposit(double money)
        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"Gửi {money} vào tài khoản thành công. Số dư hiện tại: {Balance}");
            }
            else
            {
                Console.WriteLine("Số tiền gửi không hợp lệ.");
            }
        }
        // Phương thức rút tiền
        public void Withdraw(double money)
        {
            if (money > 0 && money <= Balance)
            {
                Balance -= money;
                Console.WriteLine($"Rút {money} thành công. Số dư hiện tại: {Balance}");
            }
            else
            {
                Console.WriteLine("Số tiền rút không hợp lệ hoặc không đủ số dư.");
            }
        }

        // Phương thức lấy số dư tài khoản
        public double GetBalance()
        {
            return Balance;
        }
    }
}
