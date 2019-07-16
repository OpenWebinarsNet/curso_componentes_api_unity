using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    public static T AddOrGetComponent<T>(this GameObject go) where T : Component
    {
        T comp = go.GetComponent<T>();
        if (comp == null)
        {
            comp = go.AddComponent<T>();
        }

        return comp;
    }
}
