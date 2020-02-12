using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

using System;

public class MathApiCall : MonoBehaviour
{
    public Text Problem;

    public string url = "https://calcumon-math-api.herokuapp.com";

    public void Awake()
    {
        object ApiRequest = StartCoroutine(GetRequest(url));
        Debug.log(ApiRequest)
        Problem = gameObject.GetComponent<Text>();
        Problem.text = "sam";
    }

       IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }
}
