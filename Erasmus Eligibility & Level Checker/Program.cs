using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erasmus_Eligibility___Level_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME!");

            string name,surname;
            Console.Write("Please enter your name:");
            name = Console.ReadLine();
            Console.Write("Please enter your surname:");
            surname = Console.ReadLine();


            int idenditiy_number;
            Console.Write("Please enter your idendity number:");
            idenditiy_number = int.Parse(Console.ReadLine());

            int menuitem;
            Console.Write("Please select the item you want to access:");
            menuitem = int.Parse(Console.ReadLine());

            string applied;
            int score;

            switch (menuitem)
            {
                case 1:Console.WriteLine("Apply Page");
                       Console.WriteLine("Your application has been received successfully!");
                    break;

                case 2:Console.WriteLine("Result Page");
                       Console.Write("Did you apply before? (Yes/No): ");
                    applied = Console.ReadLine();

                    if (applied == "Yes")
                    {
                        Console.WriteLine("Please enter your erasmus score:");
                        score=int.Parse(Console.ReadLine());

                        if (score >= 65)
                        {
                            Console.WriteLine("Congratulations! You passed.");
                        }
                        else if (score >= 55)
                        {
                            Console.WriteLine("You are at B1+ level. Only 10 points left for B2!");
                        }
                        else
                        {
                            Console.WriteLine("Keep studying, you can do it!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You haven't applied yet. Please go to the Apply Page.");
                    }
                    break;

                    default:
                    Console.WriteLine("Invalid selection!");
                    break;                  
            }

            Console.Read();
        }
    }
}
