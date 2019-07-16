using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_03_Yield_Example_07_WaitWhile : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return new WaitWhile(() => Time.frameCount < 100);
        Debug.Log("Frame actual: " + Time.frameCount);
    }
}