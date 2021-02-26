using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class Request2 : MonoBehaviour
{
    private string URL=""; 
    public static DescripcionMural data;
 
    private void Awake()
    {
        GetRequest();
    }
    public string GetUrl()
    {
        URL = "https://realidadvirtual1.firebaseio.com/descripcion_mural.json";
        return URL;
    }
    public void GetRequest()
    {
        StartCoroutine(MakeWeatherRequest());
    }

    public IEnumerator MakeWeatherRequest()
    {
        UnityWebRequest request = UnityWebRequest.Get(GetUrl());
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            var weather = JsonConvert.DeserializeObject<DescripcionMural>(request.downloadHandler.text);
            data = weather;
        }
    }
}
