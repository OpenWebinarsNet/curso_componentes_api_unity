using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_05_Encadenar_paralelo : MonoBehaviour
{
    IEnumerator A(float t)
    {
        Debug.Log("A, esperando " + t + " segundos...");
        Coroutine b = StartCoroutine(B(t * 2));
        yield return new WaitForSeconds(t);
        Debug.Log("A Hecho!");
        yield return b;
        Debug.Log("B ha terminado");
    }

    IEnumerator B(float t)
    {
        Debug.Log("B, esperando " + t + " segundos...");
        yield return new WaitForSeconds(t);
        Debug.Log("B Hecho!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(A(2));
        }
    }
}