using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using System.Text;

using UnityEngine.JSONSerializeModule;

using System;

public class MathApiCall : MonoBehaviour
{
    public Text Problem;

    public string url = "https://calcumon-math-api.herokuapp.com";

    public Text result;

    

    public void Awake()
    {
        object ApiCall = StartCoroutine(GetRequest(url));
        // Debug.Log(ApiCall[0]); 
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
            StringBuilder sb = new StringBuilder();
            foreach (System.Collections.Generic.KeyValuePair<string, string> dict in webRequest.GetResponseHeaders())
            {
                sb.Append(dict.Key).Append(": \t[").Append(dict.Value).Append("]\n");
            }
            sb.ToString();
            // Print Headers
                Debug.Log("hello I am here bro");
                // https://docs.unity3d.com/ScriptReference/JsonUtility.FromJson.html
                Debug.Log(sb.ToString());
                // [System.Serializable]
                Debug.Log(webRequest.downloadHandler.text);
            }
        }
    }
}
