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
            Console.WriteLine("Great, let's get started \n");
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

            Console.Write("Place your order for ICE: \n");
            string ice = Console.ReadLine();

            Console.Write("Place your order for LEMONS: \n");
            string lemons = Console.ReadLine();

            Console.Write("Place your order for SUGAR: \n");
            var sugar = Console.ReadLine();

            Console.Write("Place your order for CUPS: \n");
            var cups = Console.ReadLine();

            var Player = new player(firstName, lastName);

            Console.WriteLine("Customer {0} {1}", Player.firstName, Player.lastName);

            //Console.WriteLine("You bought")
            //Console.WriteLine("You bought")
            //Console.WriteLine("You bought")
            //Console.WriteLine("You bought")

        }
    }
 }










