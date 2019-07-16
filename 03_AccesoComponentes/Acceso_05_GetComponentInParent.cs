using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_05_GetComponentInParent : MonoBehaviour
{
    void Start()
    {
        EnemyController ec = GetComponentInParent<EnemyController>();
        if (ec != null)
        {
            print("Soy " + name + " y encontré un EnemyController: " + ec.name);
        }
        else
        {
            print("Soy " + name + " y no se he encontrado EnemyController!");
        }

        foreach(var ec2 in GetComponentsInParent<EnemyController>())
        {
            print("De nuevo soy " + name + " y encontré un EnemyController: " + ec2.name);
        }

    }
}
