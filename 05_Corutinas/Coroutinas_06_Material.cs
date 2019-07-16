using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_06_Material : MonoBehaviour
{
    public Color targetColor = Color.red;
    public float timeToChange = 3f;
    IEnumerator ChangeColor()
    {
        Material mat = GetComponent<MeshRenderer>().material;
        Color initialColor = mat.color;
        float time = 0f;

        while (time < timeToChange)
        {
            mat.color = Color.Lerp(initialColor, targetColor, time / timeToChange);
            time += Time.deltaTime;
            yield return null;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(ChangeColor());
        }
    }
}