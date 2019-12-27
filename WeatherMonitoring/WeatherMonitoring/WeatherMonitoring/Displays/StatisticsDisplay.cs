using System;
using WeatherMonitoring.Interfaces;

namespace WeatherMonitoring.Displays
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _avgTemperature;
        private float _avgHumidity;
        private float _avgPressure;
        private ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _avgTemperature = (_avgTemperature + temperature) / 2;
            _avgHumidity = (_avgHumidity + humidity) / 2;
            _avgPressure = (_avgPressure + pressure) / 2;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Statistics:");
            Console.WriteLine("Average Temperature: " + _avgTemperature + "C.");
            Console.WriteLine("Average Humidity: " + _avgHumidity + "%");
            Console.WriteLine("Average Pressure: " + _avgPressure + "mbar");
            Console.WriteLine("");
        }
    }
}
