using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnMouseClick : MonoBehaviour
{
    public GameObject prefab;
    public float pushForce = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InstantiateOnPoint(Input.mousePosition);
        }
    }

    void InstantiateOnPoint(Vector3 screenPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if (Physics.Raycast(ray, out RaycastHit info))
        {
            // Asigna el TAG al prefab antes!!!!
            if (info.collider.CompareTag("Person") && info.rigidbody != null)
            {
                info.rigidbody.AddForce(-info.normal * pushForce, ForceMode.VelocityChange);
            }
            else
            {
                Debug.Log("Pinchado en " + info.collider.name);
                Vector3 instantiationPoint = info.point;
                GameObject newGO = Instantiate(prefab, instantiationPoint, Quaternion.identity);
                //newGO.hideFlags = HideFlags.HideInHierarchy;
                Rigidbody rb = newGO.GetComponent<Rigidbody>();
                if (rb == null)
                {
                    rb = newGO.AddComponent<Rigidbody>();
                }
            }
        }
    }
}