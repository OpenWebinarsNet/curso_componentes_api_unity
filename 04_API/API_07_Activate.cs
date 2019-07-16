using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_07_Activate : MonoBehaviour
{
    public GameObject go;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            go.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            go.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            enabled = false;
        }
    }
}