using Moq;
using NUnit.Framework;
using WeatherMonitoring;
using WeatherMonitoring.Interfaces;

namespace WeatherMonitoringTests
{
    public class Tests
    {
        private Mock<IObserver> _observer;
        private WeatherData _weatherData;

        [SetUp]
        public void Setup()
        {
            _observer = new Mock<IObserver>();
            _weatherData = new WeatherData();
        }

        [Test]
        public void NotifyObserver_WhenMesurementsChanged_CallsUpdateOnObserver()
        {
            _weatherData.RegisterObserver(_observer.Object);
            _weatherData.MesurementsChanged();
            _observer.Verify(x => x.Update(It.IsAny<float>(), It.IsAny<float>(), It.IsAny<float>()), Times.Once);
        }

    }
}