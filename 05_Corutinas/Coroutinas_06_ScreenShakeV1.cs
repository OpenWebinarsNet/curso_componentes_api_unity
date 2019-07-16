using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_06_ScreenShakeV1 : MonoBehaviour
{
    public float amount = 0.2f;
    public float shakeSpeed = 2f;
    public float shakeTime = .5f;

    bool shaking = false;
    IEnumerator Shake()
    {
        if (shaking) yield break;

        shaking = true;
        Vector3 initialLocalPosition = transform.localPosition;

        float endTime = Time.time + shakeTime;
        while(Time.time < endTime)
        {
            yield return StartCoroutine(MoveToRandomPoint(initialLocalPosition));
        }

        transform.localPosition = initialLocalPosition;
        shaking = false;
    }

    IEnumerator MoveToRandomPoint(Vector3 initialPosition)
    {
        Vector3 randomPoint = Random.onUnitSphere * amount;
        Vector3 target = initialPosition + randomPoint;
        while (Vector3.Distance(transform.localPosition, target) > 0.01f)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, shakeSpeed * Time.deltaTime);
            yield return null;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(Shake());
        }
    }
}