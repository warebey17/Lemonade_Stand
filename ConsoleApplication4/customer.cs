using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class customer
    {
        public int numOfCustomers;
        public string adults;
        public string kids;

        public customer(int numOfCustomers, string adults, string kids)
        {
            this.numOfCustomers = numOfCustomers;
            this.adults = adults;
            this.kids = kids;
        }
    }
}
