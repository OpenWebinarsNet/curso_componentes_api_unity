using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    //public GameObject bulletPrefab;
    public Transform shotPoint;

    public float speed = 5f;
    float width, height;

    private void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        height = Camera.main.orthographicSize - (sprite.rect.height / sprite.pixelsPerUnit) * 0.5f;
        width = Camera.main.orthographicSize * Camera.main.aspect - (sprite.rect.width / sprite.pixelsPerUnit) * 0.5f;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x + x, -width, width);
        newPosition.y = Mathf.Clamp(newPosition.y + y, -height, height);
        transform.position = newPosition;

        if (Input.GetKey(KeyCode.Space))
        {
            //Instantiate(bulletPrefab, shotPoint.position, Quaternion.identity);
            Pool.Instance.Get().transform.position = shotPoint.position;
        }

    }
}
