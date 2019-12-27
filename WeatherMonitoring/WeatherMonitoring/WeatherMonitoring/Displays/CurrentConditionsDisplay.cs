using System;
using WeatherMonitoring.Interfaces;

namespace WeatherMonitoring.Displays
{
    public class CurrentConditionsDisplay : IObserver , IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions:");
            Console.WriteLine("Temperature: " + _temperature + "C.");
            Console.WriteLine("Humidity: " + _humidity + "%");
            Console.WriteLine("");
        }
    }
}
