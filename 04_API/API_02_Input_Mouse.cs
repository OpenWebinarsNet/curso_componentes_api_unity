using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_02_Input_Mouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("He pulsado el botón izquierdo del ratón");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("He soltado el botón izquierdo del ratón");
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.yellow;
        GUILayout.Label("Botón izquierdo : " + Input.GetMouseButton(0));
        GUILayout.Label("Posición del ratón: " + Input.mousePosition);
    }
}
