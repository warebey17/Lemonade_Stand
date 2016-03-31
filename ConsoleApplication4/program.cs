using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {


            game Game = new game();
            Game.greet();




            //inventory Inventory = new inventory();
            //Inventory.displayInventory();

            



            {
                /*DateTime now = DateTime.Today;
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(now.ToString("dddd"));
                    Console.WriteLine(now.ToString("d"));
                    now = now.AddDays(1);
                }*/
            }

            Console.ReadKey();
        }
        
    }
}
