using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float ttl = 5f;

    void OnEnable()
    {
        StartCoroutine(BackToPoolCoroutine());
    }
    IEnumerator BackToPoolCoroutine()
    {
        yield return new WaitForSeconds(ttl);
        // Destroy(gameObject);
        Pool.Instance.Return(gameObject);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);
    }
}
