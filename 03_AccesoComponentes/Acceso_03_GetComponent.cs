using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_03_GetComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy e = GetComponent<Enemy>();
        if (e != null)
        {
            print("Encontrado componente: " + e.name);
        }
        else
        {
            print("Error, no tenemos componente Enemy!");
        }
    }
}
