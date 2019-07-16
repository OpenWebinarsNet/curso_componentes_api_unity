using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_02_Input_Axis : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("He pulsado Fire1");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Debug.Log("He soltado Fire1");
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.yellow;
        GUILayout.Label("Valor de Fire 1 : " + Input.GetButton("Fire1"));
        GUILayout.Label("Eje horizontal: " + Input.GetAxis("Horizontal"));
        GUILayout.Label("Eje vertical: " + Input.GetAxis("Vertical"));
    }
}
