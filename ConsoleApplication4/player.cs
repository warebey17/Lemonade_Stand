using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4

{
    public class player
    {
        string fName;
        string lName;


        public player(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public string firstName
        {
            get { return fName;}
            set { fName = value == "" ? "n/a" : value;}
        }

        public string lastName
        {
            get { return lName;}
            set { lName = value == "" ? "n/a" : value; }
        }
    }
}