using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ice
    {
        double oneHundredPieces = .86;
        double twoHundredFiftyPieces = 2.00;
        double fiveHundredPieces = 3.50;
        int icePurchase;
        double iceOrderTotal;
        int numIceSelected;

        public ice()
        {

        }




        public double buyIce()
        {


            // numIceSelected = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            icePurchase = random.Next(1, 3);

                //Console.WriteLine("enter ice");


                if (icePurchase == 1)
            {
                this.iceOrderTotal = numIceSelected * this.oneHundredPieces;
            }
            else if (icePurchase == 2)
            {
                this.iceOrderTotal = numIceSelected * this.twoHundredFiftyPieces;
            }
            else
            {
                this.iceOrderTotal = numIceSelected * this.fiveHundredPieces;
            }

            return iceOrderTotal;
    {

            }
        }
    }

}
