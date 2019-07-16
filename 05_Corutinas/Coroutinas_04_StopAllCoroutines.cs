using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_04_StopAllCoroutines : MonoBehaviour
{
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
            StartCoroutine(MiPrimeraCorutina(1f));
            StartCoroutine(MiPrimeraCorutina(2f));
            StartCoroutine(MiPrimeraCorutina(3f));
            StartCoroutine(MiPrimeraCorutina(4f));
            StartCoroutine(MiPrimeraCorutina(5f));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopAllCoroutines();
        }
    }
}