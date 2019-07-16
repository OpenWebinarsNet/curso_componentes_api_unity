using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_04_StartStopCoroutine_01_String : MonoBehaviour
{
    IEnumerator MiPrimeraCorutina(float t)
    {
        Debug.Log("La corutina, esperando " + t + " segundos...");
        yield return new WaitForSeconds(t);
        Debug.Log("Hecho!");
    }

    private void Update()
    {
        // Parte del start
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine("MiPrimeraCorutina", 2);
        }
        
        // Parte del stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine("MiPrimeraCorutina");
        }
    }
}