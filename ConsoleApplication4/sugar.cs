using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class sugar
    {
        double eightCups = .73;
        double twentyCups = 1.71;
        double fortyEight = 3.33;
        int sugarPurchase;
        double sugarOrderTotal;
        int numSugarSelected;

        public sugar()
        {

        }
        public double buySugar()
        {

            Random random = new Random();
            sugarPurchase = random.Next(1, 3);

            if (sugarPurchase == 1)
            {
                this.sugarOrderTotal = numSugarSelected * this.eightCups;
            }
            else if (sugarPurchase == 2)
            {
                this.sugarOrderTotal = numSugarSelected * this.twentyCups;
            }
            else
            {
                this.sugarOrderTotal = numSugarSelected * this.fortyEight;
            }
            return sugarOrderTotal;
            {
            }
        }
    }
}

