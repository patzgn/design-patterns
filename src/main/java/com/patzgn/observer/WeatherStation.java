package com.patzgn.observer;

public class WeatherStation {

    public static void main(String[] args) {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
        HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

        weatherData.setMeasurement(26.6f, 65f, 1013.1f);
        weatherData.setMeasurement(27.7f, 70f, 997.0f);
        weatherData.setMeasurement(25.5f, 90f, 997.0f);
    }

}
