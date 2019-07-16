using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_03_Yield_Example_01 : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield break;
        Debug.Log("Frame actual: " + Time.frameCount);
    }
}
