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
                Console.WriteLine("You have $20.00 in your wallet to start!  Good Luck!");
            }

            Console.Write("Please enter your FIRST NAME: \n");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your LAST NAME: \n");
            string lastName = Console.ReadLine();

            Console.Write("Enter your option for ICE: (1. 100 for .86, 2. 250 for 2.10, 3. 500 for 3.50)\n");
            string ice = Console.ReadLine();



            Console.Write("Enter your option for LEMONS: (1. 10 for .97, 2. 30 for 2.48, 3. 75 for 4.32)\n");
            string lemons = Console.ReadLine();



            Console.Write("Enter your option for SUGAR: (1. 8 for .73, 2. 20 for 1.71, 3. 48 for 3.33)\n");
            string sugar = Console.ReadLine();



            Console.Write("Enter your option for CUPS: (1. 25 for .78, 2. 50 for 1.53, 3. 100 for 2.84)\n");
            string cups = Console.ReadLine();



            var Player = new player(firstName, lastName);

            Console.WriteLine("Hello {0} {1}. Your purchase total is below.\n", Player.firstName, Player.lastName);

            ice Ice = new ice(); Console.WriteLine("Ice purchased total: " + Ice.buyIce());
            cups Cups = new cups(); Console.WriteLine("Cups purchased total: " + Cups.buyCups());
            lemon Lemon = new lemon(); Console.WriteLine("Lemon purchase total: " + Lemon.buyLemon());
            sugar Sugar = new sugar(); Console.WriteLine("Sugar purchase total: " +Sugar.buySugar());

            //Console.WriteLine("You bought")

        }
    }
 }










