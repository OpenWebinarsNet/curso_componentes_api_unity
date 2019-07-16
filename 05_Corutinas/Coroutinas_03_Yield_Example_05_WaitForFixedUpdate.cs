using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_03_Yield_Example_05_WaitForFixedUpdate : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return new WaitForFixedUpdate();
        Debug.Log("Frame actual: " + Time.frameCount);
    }

    private void FixedUpdate()
    {
        Debug.Log("Soy el FixedUpdate");
        enabled = false;
    }
}
