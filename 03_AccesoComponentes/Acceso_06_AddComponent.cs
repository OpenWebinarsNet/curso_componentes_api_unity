using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_06_AddComponent : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.AddComponent<Rigidbody>();
        }
    }

    float newMass = 1f;
    private void OnGUI()
    {
        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("Masa: ");
            newMass = float.Parse(GUILayout.TextField(newMass.ToString()));
            if (GUILayout.Button("Establecer Masa"))
            {
                Rigidbody body = gameObject.AddOrGetComponent<Rigidbody>();
                body.mass = newMass;
            }
        }
        GUILayout.EndHorizontal();
    }
}
