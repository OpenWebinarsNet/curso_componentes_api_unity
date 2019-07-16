using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_01_Invoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SayHi", 5f, 1f);
    }

    public void SayHi()
    {
        Debug.Log("Holaaaaa");
    }
}
