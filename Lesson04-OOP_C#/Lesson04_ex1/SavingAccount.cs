using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_ex1
{
    internal class SavingAccount : Account
    {
        private double rate; // Lãi suất

        // Constructor với số tiền ban đầu và lãi suất
        public SavingAccount(double initialBalance, double rate) : base(initialBalance)
        {
            this.rate = rate;
        }

        // Phương thức tính lãi suất
        public double GetInterest()
        {
            return Balance * rate;
        }
    }
    }
