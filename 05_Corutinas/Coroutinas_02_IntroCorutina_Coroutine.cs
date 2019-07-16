using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_02_IntroCorutina_Coroutine : MonoBehaviour
{
    
    float counter = 0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(CounterCoroutine());
        }
        Debug.Log("Counter desde Update: " + counter);
    }

    IEnumerator CounterCoroutine()
    {
        counter = 0f;
        while (counter < 1f)
        {
            counter += 0.1f;
            Debug.LogWarning("Counter: " + counter);
            yield return new WaitForSeconds(1f);
        }
    }
}