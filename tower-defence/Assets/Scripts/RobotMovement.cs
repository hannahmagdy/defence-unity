using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D robotRb;
    public float speed;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
         robotRb.velocity = Vector2.left * speed;

    }
}
