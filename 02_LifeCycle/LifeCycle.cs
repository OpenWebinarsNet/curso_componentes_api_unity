using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    public Transform target;

    private void Awake()
    {
        Debug.Log("Awake de " + name);
    }

    void Start()
    {
        Debug.Log("Start de " + name);
    }

    private void OnEnable()
    {
        Debug.Log("Enable de " + name);
    }

    private void OnDisable()
    {
        Debug.Log("Disable de " + name);
    }

    private void OnDestroy()
    {
        Debug.Log("Destroy de " + name);
    }

    private void Reset()
    {
        print("Hola");
    }

    private void Update()
    {
        Debug.Log("Update");
        if (!target) return;
        Vector3 newPosition = transform.position;
        newPosition.x = target.position.x;
        transform.position = newPosition;

        transform.LookAt(target);
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed");
    }

    float newX, newY, newZ;

    private void OnGUI()
    {
        GUI.color = Color.yellow;
        GUILayout.BeginHorizontal();
        GUILayout.Label("X: ");
        newX = float.Parse(GUILayout.TextField(newX.ToString(), 4));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Y: ");
        newY = float.Parse(GUILayout.TextField(newY.ToString(), 4));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Z: ");
        newZ = float.Parse(GUILayout.TextField(newZ.ToString(), 4));
        GUILayout.EndHorizontal();

        if (GUILayout.Button("Colocar"))
        {
            transform.position = new Vector3(newX, newY, newZ);
        }

    }


}

