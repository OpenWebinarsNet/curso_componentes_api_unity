using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_01_PublicProperties : MonoBehaviour
{
    public Transform otherTransform;
    public Transform[] transformsToWatch;

    void Start()
    {
        print("Usando el transform de " + otherTransform.name);

        for (int t = 0; t < transformsToWatch.Length; t++)
        {
            print("Vigilando al transform de " + transformsToWatch[t].name);
        }
    }
}
