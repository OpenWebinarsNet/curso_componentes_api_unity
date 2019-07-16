using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_02_IntroCorutina_Update : MonoBehaviour
{
    bool doCount = false;
    float counter = 0f;
    float nextCountTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter = 0f;
            doCount = true;
        }

        if (doCount && Time.time > nextCountTime)
        {
            counter += .1f;
            Debug.Log("Counter: " + counter);
            nextCountTime = Time.time + 1f;
            if (counter >= 1f)
            {
                doCount = false;
            }
        }
    }
}
