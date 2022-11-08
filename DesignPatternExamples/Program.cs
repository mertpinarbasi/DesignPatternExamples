using DesignPatternExamples.Observer;
using DesignPatternExamples.Strategy;
using DesignPatternExamples.Strategy.CharacterTypes;
using DesignPatternExamples.Strategy.WeaponBehaviors;

namespace DesignPatternExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StrategyStart
            Character warrior = new Warrior();
            warrior.fight();
            Console.WriteLine("Warrior's sword is broken");
            warrior.SetWeapon(new AxeBehavior());
            warrior.fight();
            #endregion StrategyEnd

            #region ObserverStart
            Console.WriteLine("**********************");
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            HeatIndexDisplay heatIndexDispaly = new HeatIndexDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(65, 23, 40.2f);
            weatherData.SetMeasurements(54, 16.2f, 43.2f);
            weatherData.SetMeasurements(65, 11.3f, 23.2f);
            weatherData.SetMeasurements(80, 65, 82.2f);

            #endregion ObserverEnd

        }
    }
}