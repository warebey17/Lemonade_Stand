using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class lemon
    {
        double tenLemons = .97;
        double thirtyLemons = 2.48;
        double seventyFiveLemons = 4.32;
        int lemonPurchase;
        double lemonOrderTotal;
        int numLemonSelected;

        public lemon()
        {

        }
        public double buyLemon()
        {

            Random random = new Random();
            lemonPurchase = random.Next(1, 3);

            if (lemonPurchase == 1)
            {
                this.lemonOrderTotal = numLemonSelected * this.tenLemons;
            }
            else if (lemonPurchase == 2)
            {
                this.lemonOrderTotal = numLemonSelected * this.thirtyLemons;
            }
            else
            {
                this.lemonOrderTotal = numLemonSelected * this.seventyFiveLemons;
            }
            return lemonOrderTotal;

            {
            }
        }
    }
}

