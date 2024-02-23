using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TowerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        //whenever we press space the tower will get damage, change this based on your gameplay.
        
        //if(Input.GetKeyDown(KeyCode.Space)) 
        //{
        //    TakeDamage(20);

        //}
 
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth==0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="bullet")
        {
            TakeDamage(20);
        }
    }
}
