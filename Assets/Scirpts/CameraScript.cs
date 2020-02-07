using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{

    public Transform followObject;
    private Vector3 moveTemp;

    // public Text Problem;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(Problem.GetComponent<Text>().text);

        moveTemp = followObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveTemp = followObject.transform.position;
        moveTemp.z = transform.position.z;
        transform.position = moveTemp;
    }
}
