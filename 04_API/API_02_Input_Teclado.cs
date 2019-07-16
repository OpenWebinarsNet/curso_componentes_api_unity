using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_02_Input_Teclado : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Se acaba de pulsar espacio");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Se acaba de soltar espacio");
        }

        foreach (KeyCode k in typeof(KeyCode).GetEnumValues())
        {
            if (Input.GetKeyDown(k))
            {
                Debug.Log("Se ha pulsado " + k);
            }
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.yellow;
        GUILayout.Label("Espacio pulsado? " + Input.GetKey(KeyCode.Space));
    }
}
