using System;
using WeatherMonitoring.Interfaces;

namespace WeatherMonitoring.Displays
{
    public class HeatIndex : IObserver , IDisplayElement
    {
        private float _hI;
        private ISubject _weatherData;

        public HeatIndex(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _hI = (float)(-42.379 + (2.04901523 * temperature) + (10.14333127 * humidity) -0.22475541 * temperature * humidity -0.00683783 * temperature * temperature -0.05481717 * humidity * humidity + 0.00122874 * temperature * temperature * humidity + 0.00085282 * temperature * humidity * humidity -0.00000199 * temperature * temperature * humidity * humidity);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("HeatIndex Index:");
            Console.WriteLine("Heat index is " + _hI );
            Console.WriteLine("");
        }
    }
}
