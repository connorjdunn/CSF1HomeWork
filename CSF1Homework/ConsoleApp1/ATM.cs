using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM";

            bool repeat = true;
            decimal accountBalance = 1000m;

            do
            {
                for (int i = 1; i <= 3; i++)
                {

                    Console.Write("What is your account number? ");
                    string accountNum = (Console.ReadLine());

                    if (accountNum == "12345678")
                    {
                        Console.WriteLine("You have been granted access.");

                        {
                            break;
                        }
                    }//end if

                    else
                    {
                        Console.WriteLine("You entered the incorrect account number.");
                        if (i == 3)
                        {
                            repeat = false;
                            Console.WriteLine("You have been locked out.");
                            break;

                        }//end if

                    }//end else if


                }//end for


                Console.WriteLine("What is your pin number");
                string pinNum = (Console.ReadLine());
                do
                {
                    if (pinNum == "2620")
                    {
                        Console.WriteLine("-=Would you like to \n" +
                            "A) Want to make a deposit? \n" +
                            "B) Make a withdrawal? \n" +
                            "C) View account balance: \n" +
                            "D) Exit Menu \n");
                        ConsoleKey accountMenu = Console.ReadKey().Key;
                        if (accountMenu == ConsoleKey.A)
                        {
                            Console.Clear();
                            Console.Write("Enter the amount you want to deposit: $");
                            decimal deposit = decimal.Parse(Console.ReadLine());
                            accountBalance += deposit;
                            Console.WriteLine($"${deposit} has been deposited into account number 12345678, making your account balance {accountBalance}");
                            do
                            {
                                Console.Write("Would you like to make another transaction? Y/N: ");
                                ConsoleKey returnMenu = Console.ReadKey().Key;
                                if (returnMenu == ConsoleKey.Y)
                                {
                                    Console.WriteLine("Thank you for your transaction!");
                                    Console.Clear();
                                    break;
                                }//end if

                                else
                                {
                                    repeat = false;
                                    Console.Clear();
                                    Console.WriteLine("Thank you for your transaction!");
                                    break;
                                }

                            } while (repeat == true);

                        }//end if  

                        if (accountMenu == ConsoleKey.B)
                        {
                            Console.Clear();
                            Console.Write("Enter the amount you want to withdrawal: $");
                            decimal withdrawal = decimal.Parse(Console.ReadLine());
                            accountBalance -= withdrawal;
                            Console.WriteLine($"${withdrawal} has been withdrawn from account number 12345678, making your account balance {accountBalance}");
                            do
                            {
                                Console.Write("Would you like to make another transaction? Y/N: ");
                                ConsoleKey returnMenu = Console.ReadKey().Key;
                                if (returnMenu == ConsoleKey.Y)
                                {
                                    Console.WriteLine("Thank you for your transaction!");
                                    Console.Clear();
                                    break;
                                }//end if

                                else
                                {
                                    repeat = false;
                                    Console.Clear();
                                    Console.WriteLine("Thank you for your transaction!");
                                    break;
                                }

                            } while (repeat == true);

                        }//end if

                        if (accountMenu == ConsoleKey.C)
                        {
                            Console.Clear();
                            Console.WriteLine($"Your account balance is: ${accountBalance}");

                            do
                            {
                                Console.Write("Would you like to make another transaction? Y/N: ");
                                ConsoleKey returnMenu = Console.ReadKey().Key;
                                if (returnMenu == ConsoleKey.Y)
                                {
                                    Console.WriteLine("Thank you for your transaction!");
                                    break;
                                }//end if

                                else
                                {
                                    repeat = false;
                                    Console.Clear();
                                    Console.WriteLine("Thank you for your transaction!");
                                    break;
                                }

                            } while (repeat == true);

                        }//end if

                        if (accountMenu == ConsoleKey.D)
                        {

                            repeat = false;
                            Console.Clear();
                            Console.WriteLine("Thank you for your transaction!");
                            break;

                        }//end if

                    }//end if


                } while (repeat == true);





            } while (repeat == true);




        }//end Main()

    }//end class

}//end namespace
