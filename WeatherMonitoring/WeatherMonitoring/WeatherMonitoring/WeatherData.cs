using System;
using System.Collections.Generic;
using System.Text;
using WeatherMonitoring.Interfaces;

namespace WeatherMonitoring
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        #region Observer Methods
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        #endregion

        public float GetTemperature()
        {
            return 0;
        }

        public float GetHumidity()
        {
            return 0;
        }

        public float GetPressure()
        {
            return 0;
        }

        public void SetMesurementes(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }

        public void MesurementsChanged()
        {
            NotifyObserver();
        }
    }
}
