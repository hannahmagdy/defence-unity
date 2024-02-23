using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D arrowRb;
    public float speed = 8f;
    private Vector3 _dir;
    private bool isStart;
    // Start is called before the first frame update
    void Awake()
    {
       // Destroy(gameObject,8);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart) return;
        _dir.x = _dir.z;
                
        arrowRb.velocity = (_dir * speed);
        Debug.Log(arrowRb.velocity);

    }
    public void AddDir(Vector3 dir)
    {

        isStart = true;
        _dir = dir;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.gameObject.GetComponent<EnemyHandler>();
        if (enemy != null)
        {
            enemy.TakeDamge(10);
            Destroy(gameObject);
        }
    }

}
