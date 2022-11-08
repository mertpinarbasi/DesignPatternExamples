using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Observer
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;
        public void Display()
        {
            Console.WriteLine($"Current Pressure {lastPressure}");
        }

        public ForecastDisplay(WeatherData w)
        {
            this.weatherData = w;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.Pressure;
            Display();
        }
    }
}
