using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

using System;

[Serializable] 
public class jsonDataClass
{

}

[Serializable]
public class eqn_ans
{
    
}

public class MathApiCall : MonoBehaviour
{
    // // Start is called before the first frame update
    // private const string URL = '"https://calcumon-math-api.herokuapp.com"';

    // public void Request()
    // {
    //     WWW request = new WWW(URL);
    //     StartCoroutine(OnResponse(request))
    // }

    // private IEnumerator OnResponse(WWW req)
    // {
    //     yield return req;
    // }

    public Text Problem;

    private string url = "https://calcumon-math-api.herokuapp.com";

    public void Awake()
    {
        Problem = gameObject.GetComponent<Text>();
        Problem.text = "Hello";
    }

    //  IEnumerator UWR()
    // {

    //     UnityWebRequest www = UnityWebRequest.Get(url);

    //     yield return www.sendWebRequest();
        
    //     www.downloadHandler.text
    // }

    // private void ProcessJsonData(url)
    // {
    //     jsonDataClass jsnData = JsonUtility
    // }
}
