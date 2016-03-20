using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune2
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain = "N";           
           
                Console.WriteLine("\nFortune Teller App\n");
                Console.WriteLine("Let me see into your future. \nEnter information below to help me predict your future. \n\nYou can Quit at anytime by entering \"Quit\". \nYou can restart at anytime by entering \"Restart\".\n");

            do
            { 
                Console.Write("\nEnter Your First Name: ");
                string firstName = Console.ReadLine();
                string firstNameLower = firstName.ToLower();
                
                if (firstNameLower=="quit")
                {
                    quitProgram();
                    break;
                }
                else if (firstNameLower == "restart")
                {
                    Main(args);
                    
                    break;
                }
                

                Console.Write("Enter Your Last Name: ");
                string lastName = Console.ReadLine();
                string lastNameLower = lastName.ToLower();
                string fullName = firstNameLower + lastNameLower;

                if (lastNameLower == "quit")
                {
                    quitProgram();
                    break;
                }

                else if (lastNameLower == "restart")
                {
                    Main(args);
                    break;
                }


                Console.Write("Enter Your Age: ");
                string age = Console.ReadLine().ToLower();
                

                if (age == "quit")
                {
                    quitProgram();
                    break;
                }

                else if (age == "restart")
                {
                    Main(args);
                    break;
                }

                //age if else conditional
                int userAge = int.Parse(age);
                string retireYears;
                if (userAge % 2 == 0)
                {
                    retireYears = 10.ToString();
                }
                else
                {
                    retireYears = 25.ToString();
                }



                Console.Write("Enter Your Birth Month \n(Please type out the name of the month): ");
                string birthMonth = Console.ReadLine().ToLower();

                if (birthMonth == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (birthMonth == "restart")
                {
                    Main(args);
                    break;
                }

                int fullNameLen = fullName.Length;
                double bankRoll = 0;
                for (int i = 0; i < fullNameLen; i++)
                {
                    if (birthMonth[0] == fullName[i])
                    {
                        bankRoll = 1000000.00;
                        break;
                    }
                    else if (birthMonth[1] == fullName[i])
                    {
                        bankRoll = 2000000.00;
                        break;
                    }
                    else if (birthMonth[2] == fullName[i])
                    {
                        bankRoll = 3000000.00;
                        break;
                    }
                    else
                    {
                        bankRoll = 500000.00;
                    }
                }



                Console.Write("Enter Your Favorite ROYGBIV Color \n(If you do not know ROYGBIV, enter \"Help\" to show a list of ROYGBIV colors):");
                string color = Console.ReadLine().ToLower();
                //ROYGBIV Switch Case conditional
                string transportation = "";

                if (color == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (color == "restart")
                {
                    Main(args);
                    break;
                }

                if (color == "help")
                {
                    Console.Write("ROYGBIV COLORS: \nRed. \nOrange. \nYellow. \nGreen. \nBlue. \nIndigo. \nViolet. \nEnter a ROYGBIV color(Please Type the Color's Full Name): ");
                    color = Console.ReadLine().ToLower();
                }
                switch (color)
                {
                    case "red":
                        transportation = "an electric car";
                        break;
                    case "orange":
                        transportation = "a bike";
                        break;
                    case "yellow":
                        transportation = "a SUV";
                        break;
                    case "green":
                        transportation = "a Toyota Prius";
                        break;
                    case "blue":
                        transportation = "a scooter";
                        break;
                    case "indigo":
                        transportation = "a private jet";
                        break;
                    case "violet":
                        transportation = "a yacht";
                        break;
                    default:
                        transportation = "a rusty Ford Pinto";
                        break;
                }




                Console.Write("Enter the # of Siblings You Have: ");
                string sibling = Console.ReadLine().ToLower();
                

                if (sibling == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (sibling == "restart")
                {
                    Main(args);
                    break;
                }

                // sibling sequenced if else conditional
                int sibNum = int.Parse(sibling);
                string sibFortune = ""; 
                if (sibNum == 0)
                {
                    sibFortune = "Toyko";
                }
                else if (sibNum == 1)
                {
                    sibFortune = "Washington DC";
                }
                else if (sibNum == 2)
                {
                    sibFortune = "Tanzania";
                }
                else if (sibNum == 3)
                {
                    sibFortune = "New York City";
                }
                else if (sibNum > 3)
                {
                    sibFortune = "South Beach Miami";
                }
                else
                {
                    sibFortune = "your ex's basement";
                }



                Console.WriteLine("\n\n{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and {5}.", firstName, lastName, retireYears, bankRoll, sibFortune, transportation);
                Console.Write("\nWould you like to play again? (Y or N): ");
                playAgain = Console.ReadLine().ToUpper();
            } while (playAgain == "Y");
        
        }

        static void quitProgram()
        {
            
            Console.Write("\nNobody likes a quitter.\nPress any key to Quit.\n");
            Console.ReadKey();
            
        }
        
       
    }
}

