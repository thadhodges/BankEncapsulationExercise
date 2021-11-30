using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double _balance;


        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount,0:c} to your account.");
            _balance = amount;      
        }


        public double GetBalance()
        {
            return _balance;
        }


      
        
        //public double newbalance;

        //public BankAccount(double amount)
        //{
        //    balance = amount;
        //}
        

        //public void MakeDeposit(double depositAmount)
        //{
        //    balance += depositAmount;
            
        //}
        //public void MakeWithdrawal (double withdrawalAmount)
        //{
        //    balance -= withdrawalAmount;
        //}
        //public double GetBalance()
        //{
        //    balance = newbalance;
        //        return newbalance;
        //}

        

    }
}
