using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinas_06_ScreenShakeV2 : MonoBehaviour
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

        yield return StartCoroutine(MoveToPoint(initialLocalPosition));
        shaking = false;
    }

    IEnumerator MoveToRandomPoint(Vector3 initialPosition)
    {
        Vector3 randomPoint = Random.onUnitSphere * amount;
        Vector3 target = initialPosition + randomPoint;
        yield return StartCoroutine(MoveToPoint(target));
    }

    IEnumerator MoveToPoint(Vector3 localTarget)
    {
        while (Vector3.Distance(transform.localPosition, localTarget) > 0.01f)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, localTarget, shakeSpeed * Time.deltaTime);
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