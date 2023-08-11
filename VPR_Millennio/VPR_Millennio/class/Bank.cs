using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPR_Millennio.@class
{
    internal class Bank
    {
        private int currentLoan;
         
        public Bank()
        {
            currentLoan = 0;
        }

        public int CurrentLoan => currentLoan;

        public int TakeLoan(int amount)
        {
            if (currentLoan == 0)
            {
                currentLoan = amount;
                return amount;
            }
            // Only one loan at a time, so you can add else statement to handle multiple loans
            return 0;
        }

        public void PayBack(int amount)
        {
            currentLoan -= amount;
            if (currentLoan < 0)
            {
                currentLoan = 0;
            }
        }
        
    }
}
