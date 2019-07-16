using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_03_Yield_Example_06_WaitUntil : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return new WaitUntil(() => Time.frameCount >= 100);
        Debug.Log("Frame actual: " + Time.frameCount);
    }
}