using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_04_Camera : MonoBehaviour
{
    public Camera myCamera;
    private void Start()
    {
        if (Camera.main == myCamera)
        {
            Debug.Log("Misma cámara");
        }
        // Ejemplo 4: Viewport to World
        Debug.Log("Límites: " + Camera.main.ViewportToWorldPoint(Vector3.one));

        // Ejemplo 5: Necesita la cámara en Orto
        Debug.Log("Alto de la cámara: " + Camera.main.orthographicSize);
        Debug.Log("Ancho de la cámara: " + Camera.main.orthographicSize * Camera.main.aspect);
    }

    private void Update()
    {
        // Ejemplo 2: Screen To World
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10f;
            transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }
        // Ejemplo 1: Screen To Viewport
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 viewPortPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            string horizontal = "Ninguno";
            string vertical = "ninguno";

            if (viewPortPosition.x > 0.5f)
            {
                horizontal = "Derecha";
            }
            else
            {
                horizontal = "Izquierda";
            }

            vertical = viewPortPosition.y > 0.5f ? "Arriba" : "Abajo";

            Debug.LogFormat("{0} - {1}", vertical, horizontal);
        }
    }

    private void OnGUI()
    {
        // Ejemplo 3: World to ViewPort
        GUI.color = Color.yellow;
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);
        string horizontal = "Ninguno";
        string vertical = "ninguno";

        if (viewportPosition.x > 0.5f)
        {
            horizontal = "Derecha";
        }
        else
        {
            horizontal = "Izquierda";
        }

        vertical = viewportPosition.y > 0.5f ? "Arriba" : "Abajo";

        GUILayout.Label(string.Format("{0} - {1}", vertical, horizontal));
    }
}