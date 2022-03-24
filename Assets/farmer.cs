using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmer : MonoBehaviour
{

    [SerializeField] private float speed = 1f;
    [SerializeField] private float maxDistance = 1f;
    [SerializeField] private float minDistance = 1f;
    [SerializeField] private Sprite[] sprites;

    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
        if (transform.position.x > maxDistance)
        {
            speed = -speed;
            sr.sprite = sprites[1];
        }
        if (transform.position.x < minDistance)
        {
            speed = -speed;
            sr.sprite = sprites[0];
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
