using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_02_FindObjectOfType : MonoBehaviour
{
    void Start()
    {
        //Enemy anEnemy = (Enemy)FindObjectOfType(typeof(Enemy));
        Enemy anEnemy = FindObjectOfType<Enemy>();

        if (anEnemy != null)
        {
            print("Encontrado un enemigo: " + anEnemy.name);
        }

        Enemy[] enemyList = FindObjectsOfType<Enemy>();
        foreach (Enemy enemy in enemyList)
        {
            print("Un nuevo enemigo: " + enemy.name);
        }
    }
}
