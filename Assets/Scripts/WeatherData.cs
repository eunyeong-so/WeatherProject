using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System;
using Newtonsoft.Json;
using UnityEngine.UI;

public class WeatherData : MonoBehaviour
{
    private const string apiKey = "037a6b873a377d77791581aad7e067fe";
    public string cityName = "seoul";

   
    private void Start()
    {
        string url = String.Format("api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", cityName, apiKey);
       
        StartCoroutine(GetWeather(url));

    }

    IEnumerator GetWeather(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {

            yield return webRequest.SendWebRequest();
            if (webRequest.isNetworkError)
            {
                Debug.Log("Web reqeust error" + webRequest.error);

            }
            else
            {
                var weather = JsonConvert.DeserializeObject<WeatherContionInfo>(webRequest.downloadHandler.text);

                Debug.Log("weather id: " + weather.name);
                Debug.Log("weather description: " + weather.weather[0].description);
                Debug.Log("weather Icon: " + weather.weather[0].icon);
                Debug.Log("weather temp: " + weather.GetCelsius());

            }

        }

    }

}
 