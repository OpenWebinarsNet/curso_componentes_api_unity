using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_05_Time : MonoBehaviour
{
    // Este es el ejemplo
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Time.timeScale = 0.2f;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 2f;
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label("Tiempo: " + Time.time);
        GUILayout.Label("Tiempo sin escala: " + Time.unscaledTime);
        GUILayout.Label("Tiempo desde arranque: " + Time.realtimeSinceStartup);
        GUILayout.Label("Tiempo desde carga del nivel: " + Time.timeSinceLevelLoad);
        GUILayout.Label("Frame DeltaTime: " + Time.deltaTime);
        GUILayout.Label("Frame Fixed DeltaTime: " + Time.fixedDeltaTime);
        GUILayout.Label("Escala de tiempo: " + Time.timeScale);
    }
}