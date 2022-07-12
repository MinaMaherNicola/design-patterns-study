//using HeadFirstDesignPatterns.StrategyPattern;

//ScenarioGenerator.GenerateBeforeDesignScenario();
//Console.WriteLine("\n||||||||||||||||\n");
//ScenarioGenerator.GenerateAfterDesignScenario();

using HeadFirstDesignPatterns.ObserverPattern.Displays;
using HeadFirstDesignPatterns.ObserverPattern.WeatherMainSystem;

WeatherObject weatherObject = new();
CurrentWeatherDisplay currentWeatherDisplay = new(weatherObject);
PressureDisplay pressureDisplay = new(weatherObject);

weatherObject.GetNewMeasurementsFromHardware();
weatherObject.GetNewMeasurementsFromHardware();
currentWeatherDisplay.Unsubscribe();

// Only pressure observer is available
weatherObject.GetNewMeasurementsFromHardware();
weatherObject.GetNewMeasurementsFromHardware();


pressureDisplay.Unsubscribe();

// no subscribed observers available
weatherObject.GetNewMeasurementsFromHardware();
weatherObject.GetNewMeasurementsFromHardware();
weatherObject.GetNewMeasurementsFromHardware();
weatherObject.GetNewMeasurementsFromHardware();
weatherObject.GetNewMeasurementsFromHardware();
weatherObject.GetNewMeasurementsFromHardware();