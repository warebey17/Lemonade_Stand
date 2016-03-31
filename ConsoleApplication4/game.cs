using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class game 
    {

        public int decisionToPlay;

        public game()
        {
        }

        public game(int decisionToPlay)
        {

            
        }

    public void greet()
    {
            
            Console.WriteLine("HELLO, WELCOME TO QUENTIN's LEMONADE STAND!\n");
            //string name = Console.ReadLine();
            Console.Write("Would you like to play? (Enter 1 for YES or 2 for NO)");

            decisionToPlay = Convert.ToInt32(Console.ReadLine());
            

            if ( decisionToPlay == 1)

        {
                Console.WriteLine("Great, let's get started!!!!!!!! \n");
                Console.WriteLine("You have 7 days to make as much money as possible!");
                Console.WriteLine("You’ll have complete control over your business,");
                Console.WriteLine("including pricing, inventory control, and purchasing supplies.");
                Console.WriteLine("Buy your ingredients and start selling! \n");
                Console.WriteLine("Click enter/return to continue");
                Console.ReadLine();
        }
        else
        {
            Console.WriteLine("GAME OVER! BYE BYE!");
            Thread.Sleep(4000);
            Environment.Exit(0);
          }




            {
                weather Weather = new weather();

                DateTime now = DateTime.Today;
                for (int i = 0; i < 1; i++)

                Console.WriteLine(now.ToString("dddd") + "'s forecast is " + Weather.GetWeather() + " with a high of " + Weather.GetTemperature() + "°");
                Console.WriteLine("The demand for lemonade is " + Weather.GetLemonadeDemand() + "%");
                Console.WriteLine(" ");
            }

            Console.Write("Please enter your FIRST NAME: \n");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your LAST NAME: \n");
            string lastName = Console.ReadLine();

            Console.Write("Enter your option for ICE: (a. 100 @ .86, b. 250 @ 2.10, c. 500 @ 3.50)\n");
            string ice = Console.ReadLine();

            Console.Write("Enter your option for LEMONS: (a. 10 @ .97, b. 30 @ 2.48, c. 75 @ 4.32)\n");
            string lemons = Console.ReadLine();

            Console.Write("Enter your option for SUGAR: (a. 8 @ .73, b. 20 @ 1.71, c. 48 @ 3.33)\n");
            string sugar = Console.ReadLine();

            Console.Write("Enter your option for CUPS: (a. 25 @ .78, b. 50 @ 1.53, c. 100 @ 2.84)\n");
            string cups = Console.ReadLine();

            var Player = new player(firstName, lastName);

            Console.WriteLine("Hello {0} {1}", Player.firstName, Player.lastName);

            //Console.WriteLine("You bought")
            //Console.WriteLine("You bought")
            //Console.WriteLine("You bought")
            //Console.WriteLine("You bought")

        }
    }
 }










