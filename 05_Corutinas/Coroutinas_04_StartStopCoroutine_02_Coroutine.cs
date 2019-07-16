using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_04_StartStopCoroutine_02_Coroutine : MonoBehaviour
{
    Coroutine cr;

    IEnumerator MiPrimeraCorutina(float t)
    {
        Debug.Log("La corutina, esperando " + t + " segundos...");
        yield return new WaitForSeconds(t);
        Debug.Log("Hecho!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cr = StartCoroutine(MiPrimeraCorutina(3f));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine(cr);
        }
    }
}