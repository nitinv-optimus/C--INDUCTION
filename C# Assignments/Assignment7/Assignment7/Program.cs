using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Output is 0.04,0.08,0.08 as currInterestRate variable is declared as static so it will be present in static memory
    and will not be assigned differently to the objects created, so when any object changes or updates its value ,
    it will be updated in the static memory and will be visible to the whole class
*/  
namespace Assignment7
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate = 0.04;
        public SavingsAccount(double balance) { currBalance = balance; }
        public static void SetInterestRate(double newRate) { currInterestRate = newRate; }
        public static double GetInterestRate() { return currInterestRate; }
        public void SetInterestRateObj(double newRate) { currInterestRate = newRate; }
        public double GetInterestRateObj() { return currInterestRate; }
        static void Main(string[] args)
        {
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Interest Rate is: {0}",
            s1.GetInterestRateObj());
            s2.SetInterestRateObj(0.08);
            Console.WriteLine("Interest Rate is: {0}",
            s1.GetInterestRateObj());
            SavingsAccount s3 = new SavingsAccount(10000.75);
        Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }

    }
}
