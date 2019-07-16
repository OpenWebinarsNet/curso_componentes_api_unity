using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [Header("Shake Properties")]
    public float shakeAmount = 0.2f;
    public float shakeSpeed = 20f;
    public float shakeTime = 4f;

    [Header("Scale Properties")]
    public AnimationCurve scaleCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
    public float scaleAmount = 2f;
    public float scaleTime = 2f;

    [Header("Particles Properties")]
    public ParticleSystem explosionParticles;

    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(BombCoroutine());
        }
    }

    IEnumerator BombCoroutine()
    {
        Coroutine shakeCoroutine = StartCoroutine(SimpleShakeCoroutine());

        float currentScaleTime = 0f;
        Vector3 originalScale = transform.localScale;
        while (currentScaleTime < scaleTime)
        {
            float dt = currentScaleTime / scaleTime;
            Vector3 newScale = originalScale + originalScale * scaleCurve.Evaluate(dt) * (scaleAmount - 1f);
            transform.localScale = newScale;
            currentScaleTime += Time.deltaTime;
            yield return null;
        }
        transform.localScale = originalScale * scaleAmount;
        yield return shakeCoroutine;

        spriteRenderer.enabled = false;

        explosionParticles.Play();

        while (explosionParticles.isPlaying)
        {
            yield return null;
        }

        Debug.Log("Yata :)");

    }

    IEnumerator SimpleShakeCoroutine()
    {
        Vector3 initialLocalPosition = transform.localPosition;

        float endTime = Time.time + shakeTime;
        while (Time.time < endTime)
        {
            Vector3 randomPoint = Random.onUnitSphere * shakeAmount;
            transform.localPosition = initialLocalPosition + randomPoint;
            yield return null;
        }
        transform.localPosition = initialLocalPosition;
    }

}
