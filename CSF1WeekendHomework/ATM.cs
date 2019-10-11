using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1WeekendHomework
{
    class ATM
    {
        static void Main(string[] args)
        {

            decimal accountBalance = 0;
            bool entry = false;
            
            while (entry == false)
            {
                Console.WriteLine("Please enter your 9 digit account number: ");
                
                long acctNumUserInput = long.Parse(Console.ReadLine());
                long acctNum = 123456789;

                if (acctNumUserInput == acctNum)
                {
                    entry = true;
                }
                else
                {
                    Console.WriteLine("The number you entered didn't match any account numbers on record...");
                    entry = false;
                }//end if else
                
            
            }//end loop
            Console.Clear();
            Console.WriteLine("Thank you.");

            

            entry = false;

            while (entry == false)
            {
                Console.WriteLine("Please enter your four digit Personal Identification Number (P.I.N)");
                long pinUserInput = long.Parse(Console.ReadLine());
                long pin = 1234;

                if (pinUserInput == pin)
                {
                    entry = true;
                }
                else
                {
                    Console.WriteLine("The P.I.N you entered is incorrect");
                    entry = false;
                        
                }//end if
            }//end loop            
            bool repeat = true;
            do
            {
                Console.WriteLine("\nWhat can we help you with today? \n1.) (W)ithdraw \n2. (D)eposit \n.3 e(X)it");
                string userChoice = Console.ReadLine().ToUpper();

                Console.Clear();

                switch (userChoice)
                {
                    case "W":
                        Console.WriteLine("How much would you like to withdraw?");
                        string withdraw = Console.ReadLine();
                        decimal newBalance1 = accountBalance - decimal.Parse(withdraw);
                        accountBalance = accountBalance - decimal.Parse(withdraw);
                        if (newBalance1 < 0)
                        {
                            Console.WriteLine("You do not have enough money to complete this transaction");
                            newBalance1 = accountBalance + decimal.Parse(withdraw);
                        }

                        else
                        {
                            Console.WriteLine("You have successfully withdrawn {0:c}. Your new account balance is {1:c}. ", withdraw , newBalance1);
                        }
                        Console.Write("Would you like to complete another transaction? Y/N");
                        Console.ReadLine().ToUpper();
                        if (Console.ReadLine() == "Y")
                        {
                            repeat = true;
                        }
                        else
                        {
                            Console.WriteLine("Thank you for banking with us. We hope to see you again. ");
                            repeat = false;
                        }
                        break;

                    case "D":
                        Console.WriteLine("Please enter the amount of your deposit");
                        string deposit = Console.ReadLine();
                        decimal newBalance2 = accountBalance + decimal.Parse(deposit);
                        accountBalance = accountBalance + decimal.Parse(deposit);
                        Console.WriteLine("You have successfully deposited {0:c}. Your new account balance is {1:c}. ", deposit, newBalance2);
                        Console.Write("Would you like to complete another transaction? Y/N");
                        Console.ReadLine().ToUpper();
                        if (Console.ReadLine() == "Y")
                        {
                            repeat = true;
                        }
                        else
                        {
                            Console.WriteLine("Thank you for banking with us. We hope to see you again. ");
                            repeat = false;
                        }
                        break;

                    case "X":
                        Console.WriteLine("Thank you for banking with us. We hope to see you again. ");
                        repeat = false;
                        break;
  
                }//end Switch
            } while (repeat);

        }//end Main()
    }//end class
}//end  Namespace