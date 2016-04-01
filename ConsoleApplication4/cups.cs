using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class cups
    {
        double twentyFiveCups = .78;
        double fiftyCups = 1.53;
        double onehundredCups = 2.84;
        int cupPurchase;
        double cupOrderTotal;
        int numCupSelected;


        public cups()
        {
           
        }
        public double buyCups()
        {

            Random random = new Random();
            cupPurchase = random.Next(1, 3);

            if (cupPurchase == 1)
            {
                this.cupOrderTotal = numCupSelected * this.twentyFiveCups;
                    
            }
            else if (cupPurchase == 2)
            {
                this.cupOrderTotal = numCupSelected * this.fiftyCups;
            }
            else
            {
                this.cupOrderTotal = numCupSelected * this.onehundredCups;
            }
            return cupOrderTotal;
            {
            }
       }
    }
}
