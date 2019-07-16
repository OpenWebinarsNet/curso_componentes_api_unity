using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public static Pool Instance { get; private set; }

    public GameObject prefab;
    public int initialAmount = 50;

    public List<GameObject> poolObjects = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
        FillPool();
    }

    private void FillPool()
    {
        for (int t = 0; t < initialAmount; t++)
        {
            GameObject go = Instantiate(prefab);
            go.SetActive(false);
            poolObjects.Add(go);
        }
    }

    public GameObject Get()
    {
        GameObject ret;

        if (poolObjects.Count > 0)
        {
            ret = poolObjects[poolObjects.Count - 1];
            poolObjects.RemoveAt(poolObjects.Count - 1);
        }
        else
        {
            ret = Instantiate(prefab);
        }
        ret.SetActive(true);
        return ret;
    }

    public void Return(GameObject go)
    {
        go.SetActive(false);
        poolObjects.Add(go);
    }
}
