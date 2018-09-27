using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmS
{
    class Weather
    {
        public string Condition;
        public int Temperature;
        public string ConditionForecast;
        public int TemperatureForecast;


        List<string> PossibleConditions;
        public Weather()
        {
            PossibleConditions.Add("Sunny");
            PossibleConditions.Add("Rain");
            PossibleConditions.Add("Cloudy");
            PossibleConditions.Add("Snow");

        }

        public void RandomCondition()
        {
            Random random = new Random();
            Condition = PossibleConditions[random.Next(0, PossibleConditions.Count)];
                
        }
        public void RandomConditionForecast()
        {
            Random random = new Random();
            ConditionForecast = PossibleConditions[random.Next(0, PossibleConditions.Count)];
        }
        public void RandomTemperature()
        {
            Random random = new Random();
            Temperature = random.Next(55, 99);

        }
        public void RandomTemperatureForecast()
        {
            Random random = new Random();
            TemperatureForecast = random.Next(55, 99);
        }
        









    }
}
