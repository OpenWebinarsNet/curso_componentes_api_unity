using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Range(0f, 360f)]
    public float visionAngle = 45f;
    public float visionDistance = 1f;
    [Range(1, 45)]
    public int segments = 5;

    private void OnDrawGizmos()
    {
        if (visionAngle <= 0f) return;

        float halfVisionAngle = visionAngle * 0.5f;

        Vector2 p1, p2;
        p1 = PointForAngle(halfVisionAngle);
        p2 = PointForAngle(-halfVisionAngle);

        Gizmos.DrawLine(transform.position, (Vector2)transform.position + p1);
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + p2);

        Gizmos.color = Color.yellow;
        float offset = halfVisionAngle / segments;
        p1 = transform.position + PointForAngle(-halfVisionAngle);

        for (float currentAngle = -halfVisionAngle + offset; currentAngle < halfVisionAngle + offset; currentAngle += offset * 2f)
        {
            float nextAngle = Mathf.Clamp(currentAngle + offset, -halfVisionAngle, halfVisionAngle);
            p2 = transform.position + PointForAngle(nextAngle);
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(p1, p2);

            // Debug Points
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(p1 * 1.2f, 0.2f);
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(p2 * 1.1f, 0.1f);

            // Debug Line
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(p1 * 1.2f, p2 * 1.1f);

            p1 = p2;
        }
    }

    Vector3 PointForAngle(float angle)
    {
        return transform.TransformDirection(new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad) * visionDistance,
                Mathf.Sin(angle * Mathf.Deg2Rad) * visionDistance));
    }
}
