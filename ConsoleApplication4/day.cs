using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class day : weather
    {
        public string Sunday;
        public string Monday;
        public string Tuesday;
        public string Wednesday;
        public string Thursday;
        public string Friday;
        public string Saturday;

        public day(int temp, string forecast, double lemonadeDemand, double sunFactor, double rainFactor, string Sunday, string Monday, string Tuesday, string Wednesday, string Thursday, string Friday, string Saturday)
            : base(temp, forecast, lemonadeDemand)
        {
            this.Sunday = Sunday;
            this.Monday = Monday;
            this.Tuesday = Tuesday;
            this.Wednesday = Wednesday;
            this.Thursday = Thursday;
            this.Friday = Friday;
            this.Saturday = Saturday;

            List<string> dayOfWeek = new List<string>();
            {
                dayOfWeek.Add("Sunday");
                dayOfWeek.Add("Monday");
                dayOfWeek.Add("Tuesday");
                dayOfWeek.Add("Wednesday");
                dayOfWeek.Add("Thursday");
                dayOfWeek.Add("Friday");
                dayOfWeek.Add("Saturday");


            }

        }
    }
}
