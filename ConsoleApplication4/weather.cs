using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4

{
    public class weather
{
        public int temp;
        public string forecast;
        public double lemonadeDemand;
        public double sunFactor;
        public double overcast;
        public double rainFactor;
        public int clearSky;

        public weather(int temp, string forecast, double lemonadeDemand)
        {
            this.temp = temp;
            this.forecast = forecast;
            this.lemonadeDemand = lemonadeDemand;
            this.sunFactor = 1.08;
            this.overcast = .95;
            this.rainFactor = .34;
            this.clearSky = 1;

        }
        public weather()
        {

        }
        public int GetTemperature()
        {
            Random random = new Random();
            temp = random.Next(55, 91);
            return temp;
        }
        
        public string GetWeather()
        {
            Random random = new Random();
            int precipAssigner = random.Next(1, 4);
            if (precipAssigner == 1)
            {
                this.forecast = "Rainy";
            }
            else if (precipAssigner == 2)
            {
                this.forecast = "Sunny";
            }
            else if (precipAssigner == 3)
            {
                this.forecast = "Clear";
            }
            else
            {
                this.forecast = "Overcast";
            }
            return this.forecast;
        }


        public double GetLemonadeDemand()
        {
            //if statement to determine the demand for Lemonade
            if (this.forecast == "Rainy")
            {
                this.lemonadeDemand = temp * .34;

            }
            else if (this.forecast == "Overcast")
            {
                this.lemonadeDemand = temp * .95;
            }
            else if (this.forecast == "Clear")
            {
                this.lemonadeDemand = temp;
            }
            else
            {
                this.lemonadeDemand = temp * 1.08;
            }
            return lemonadeDemand;
        }
    }
}