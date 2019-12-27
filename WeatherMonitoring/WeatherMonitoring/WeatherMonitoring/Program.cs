using System;
using WeatherMonitoring.Displays;

namespace WeatherMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Weather Station!");

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            HeatIndex heatIndex = new HeatIndex(weatherData);
            //TODO
            //ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMesurementes(35, 80, 30.4f);
            weatherData.MesurementsChanged();

            weatherData.SetMesurementes(14, 62, 32.4f);
            weatherData.MesurementsChanged();

            weatherData.SetMesurementes(30, 85, 31.5f);
            weatherData.MesurementsChanged();


          

    
        }
    }
}
