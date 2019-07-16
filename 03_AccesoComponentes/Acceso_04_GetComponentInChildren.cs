using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_04_GetComponentInChildren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy unEnemigo = GetComponentInChildren<Enemy>(true);
        if (unEnemigo)
        {
            print("Enemigo hijo: " + unEnemigo.name);
        } else
        {
            print("No hay hijos con el componente Enemigo");
        }

        var enemyList = GetComponentsInChildren<Enemy>(true);
        foreach(var e in enemyList)
        {
            print("Enemigo de la lista: " + e.name);
        }
    }
}