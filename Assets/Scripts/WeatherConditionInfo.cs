using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class WeatherContionInfo
{
    public Coord coord { get; set; }
    public List<Weather> weather { get; set; }
    public string @base { get; set; }
    public Main main { get; set; }
    public int visibility { get; set; }
    public Wind wind { get; set; }
    public Clouds clouds { get; set; }
    public int dt { get; set; }
    public Sys sys { get; set; }
    public int timezone { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public int cod { get; set; }


    public int GetCelsius()
    {
        //Origin data is kelvin
        //292.73K − 273.15 = 19.58°C

        return Mathf.RoundToInt(main.temp - 273.15f);
    }

    public string GetWeatherIcon()
    {
        string iconNumber = weather[0].icon;
        string imageUrl = " http://openweathermap.org/img/wn/" + iconNumber + "@2x.png";

        return imageUrl;
    }
}


public class Coord
{
    public double lon { get; set; }
    public double lat { get; set; }
}

public class Weather
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}

public class Main
{
    public float temp { get; set; }
    public double feels_like { get; set; }
    public double temp_min { get; set; }
    public double temp_max { get; set; }
    public int pressure { get; set; }
    public int humidity { get; set; }
    public int sea_level { get; set; }
    public int grnd_level { get; set; }
}

public class Wind
{
    public double speed { get; set; }
    public int deg { get; set; }
    public double gust { get; set; }
}

public class Clouds
{
    public int all { get; set; }
}

public class Sys
{
    public int type { get; set; }
    public int id { get; set; }
    public string country { get; set; }
    public int sunrise { get; set; }
    public int sunset { get; set; }
}
 

