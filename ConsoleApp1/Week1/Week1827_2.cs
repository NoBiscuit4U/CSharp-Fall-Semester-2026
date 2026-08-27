using System;
using ConsoleApp1;

namespace ConsoleApp1{
    class Week1827_2{
        public void test(){
            double balance=1000;
            while(true){
                Console.WriteLine("Enter Desired Operation: BALANCE:1, WITHDRAW:2, DEPOSIT:3, QUIT:4");
                int operation = int.Parse(Console.ReadLine());

                switch(operation){
                    case 1:
                        Console.WriteLine("Your Balance is: {0}", balance);
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to withdraw");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        balance -= withdrawAmount;
                        Console.WriteLine("You have withdrawn: {0}", withdrawAmount);
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount to deposit");
                        double depositAmount = double.Parse(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine("You have deposited: {0}", depositAmount);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our services.");
                        return; // Exit the method to quit
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        break;
                }
            }
        }
    }
}

