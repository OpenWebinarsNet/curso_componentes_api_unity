using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_02_Input_Mobile : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch currentTouch = Input.GetTouch(0);
            if (currentTouch.phase == TouchPhase.Began)
            {
                Debug.Log("Se acaba de tocar en " + currentTouch.position);
            }
            else if (currentTouch.phase == TouchPhase.Ended)
            {
                Debug.Log("Se levantó el dedo de " + currentTouch.position);
            }
        }
    }
    private void OnGUI()
    {
        GUI.color = Color.yellow;
        GUILayout.Label("Toques: " + Input.touchCount);
        foreach (Touch touch in Input.touches)
        {
            Label("Touch Position", touch.position.ToString());
        }

        GUILayout.Label("Acelerómetro: " + Input.acceleration);
    }

    void Label(string l, string t)
    {
        GUILayout.Label(l + ": " + t);
    }
}
