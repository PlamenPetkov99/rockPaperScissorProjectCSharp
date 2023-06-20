using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the prototype of Rock,Paper,Scissor");
            Console.Write("So do you want to try it? Y(Yes)/N(No) :   ");
            string decission = Console.ReadLine();
            bool play = true;
            string[] choosingArray = {"R","P","S"};
            Random rnd = new Random();
            

            if (decission == "N"||decission == "No")
            {
                play = false;
            }

            while (play != false)
            {
                int num = rnd.Next(0, 3);
                string choice = choosingArray[num];

                Console.WriteLine("Now you should choice between [R]Rock , [P]Paper , [S]Scissor");
                string myChoice = Console.ReadLine();

                switch (myChoice)
                {
                    case "R":
                        if(choice == "R")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (choice == "S")
                        {
                            Console.WriteLine("Congratulation You Won");
                        }
                        else if(choice == "P")
                        {
                            Console.WriteLine("Sorry , you lost :(");
                        }
                        break;
                    case "P":
                        if (choice == "P")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (choice == "R")
                        {
                            Console.WriteLine("Congratulation You Won");
                        }
                        else if (choice == "S")
                        {
                            Console.WriteLine("Sorry , you lost :(");
                        }
                        break;
                    case "S":
                        if (choice == "S")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (choice == "P")
                        {
                            Console.WriteLine("Congratulation You Won");
                        }
                        else if (choice == "R")
                        {
                            Console.WriteLine("Sorry , you lost :(");
                        }
                        break;
                    default:
                        Console.WriteLine("You picked a invalid value ");
                        
                        continue;
                }

                Console.WriteLine("Do you want to try it again ? (Y/N) ");
                decission = Console.ReadLine();
                if (decission == "N" || decission == "No")
                {
                    play = false;
                }
                else if(decission == "Y" || decission == "Yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("You didnt pick but we consider that as YES");
                }
            }

            Console.WriteLine("Thank you for trying my prototype of the game");
        }
    }
}
