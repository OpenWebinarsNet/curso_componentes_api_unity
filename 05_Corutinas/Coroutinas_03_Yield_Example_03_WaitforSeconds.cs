using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_03_Yield_Example_03_WaitforSeconds : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return new WaitForSeconds(3f);
        Debug.Log("Frame actual: " + Time.frameCount);
    }
}
