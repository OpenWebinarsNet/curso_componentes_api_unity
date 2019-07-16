using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_05_Encadenar : MonoBehaviour
{
    IEnumerator A(float t)
    {
        Debug.Log("A, esperando " + t + " segundos...");
        yield return StartCoroutine(B(t * 2));
        Debug.Log("B ha terminado, continua A");
        yield return new WaitForSeconds(t);
        Debug.Log("A Hecho!");
    }

    IEnumerator B(float t)
    {
        Debug.Log("B, esperando " + t + " segundos...");
        yield return new WaitForSeconds(t);
        yield return StartCoroutine(C(t/2));
        Debug.Log("B Hecho!");
    }

    IEnumerator C(float t)
    {
        Debug.Log("C, esperando " + t + " segundos...");
        yield return new WaitForSeconds(t);
        Debug.Log("C Hecho!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(A(2));
        }
    }
}