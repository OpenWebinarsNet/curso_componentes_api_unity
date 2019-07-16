using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_03_Yield_Example_04_WaitforSecondsRealtime : MonoBehaviour
{
    IEnumerator Start()
    {
        Time.timeScale = 0.2f;
        Debug.Log("Frame actual: " + Time.frameCount);
        //yield return new WaitForSeconds(1f);
        yield return new WaitForSecondsRealtime(1f);
        Debug.Log("Frame actual: " + Time.frameCount);
    }
}
