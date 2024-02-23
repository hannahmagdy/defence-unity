
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Rigidbody2D arrowRb;
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        arrowRb.velocity = Vector2.left * speed;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Tower")
        {
            Destroy(gameObject);
        }
    }
}

