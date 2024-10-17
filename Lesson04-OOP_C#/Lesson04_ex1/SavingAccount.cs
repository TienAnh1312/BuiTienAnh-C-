using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ex1
{
    internal class SavingAccount:Account
    {
        private double feeTransfer; // Phí giao dịch

        // Constructor với số tiền ban đầu và phí giao dịch
        public CheckAccount(double initialBalance, double feeTransfer) : base(initialBalance)
        {
            this.feeTransfer = feeTransfer;
        }

        // Override phương thức rút tiền để trừ thêm phí giao dịch
        public new void Withdraw(double money)
        {
            double totalAmount = money + feeTransfer;

            if (totalAmount <= Balance)
            {
                Balance -= totalAmount;
                Console.WriteLine($"Rút {money} (bao gồm phí {feeTransfer}) thành công. Số dư hiện tại: {Balance}");
            }
            else
            {
                Console.WriteLine("Không đủ số dư để thực hiện giao dịch.");
            }
        }
    }
}
