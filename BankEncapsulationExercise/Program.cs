using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much $$$ do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);
            double newbalance = ba.GetBalance();

            Console.WriteLine($"Your current Balance is {newbalance, 0:c}");



        }
    }
}
