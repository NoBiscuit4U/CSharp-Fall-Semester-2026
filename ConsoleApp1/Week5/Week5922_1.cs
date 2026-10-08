using System;
using System.IO.Compression;

namespace ConsoleApp1{
    public abstract class Payment{
        public abstract void ProcessPayment(double amount);
        public void DisplayReceipt(){
            Console.WriteLine("Thank you for your payment.");
        }
    }

    public class CreditCardPayment : Payment{
        public override void ProcessPayment(double amount){
            Console.WriteLine("Processing credit card payment of {0}",amount);
        }
    }

    public class PayPalPayment : Payment{
        public override void ProcessPayment(double amount){
            Console.WriteLine("Processing PayPal payment of {0}",amount);
        }
    }
}