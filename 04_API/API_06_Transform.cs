using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_06_Transform : MonoBehaviour
{
    public Transform lookAtTarget;
    public float linealSpeed = 10f;
    public float angularSpeed = 90f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * linealSpeed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * linealSpeed * Time.deltaTime;

        transform.Translate(h, 0f, v, Space.World);

        transform.Rotate(0f, angularSpeed * Time.deltaTime, 0f);

        transform.LookAt(lookAtTarget);

    }
}