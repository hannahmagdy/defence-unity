using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] private float maxHp = 100;
    [SerializeField] private float hp = 0;

    void Start()
    {
        hp = maxHp;        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) { 
            Destroy(gameObject);
        }
    }
    public void TakeDamge(int val) {
        hp -= val;
    }
}
