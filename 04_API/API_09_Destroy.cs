using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_09_Destroy : MonoBehaviour
{
    public GameObject objectToDestroy;
    public Rigidbody body;

    private void Update()
    {
        // Ejemplo 1
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(objectToDestroy);
        }

        // Ejemplo 2
        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(gameObject);
        }
        // Ejemplo 3
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(body);
            Destroy(transform);
        }

        // Ejemplo 4
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Destruyendo con 5 segundos de retraso");
            Destroy(objectToDestroy, 5f);
        }


    }
}