using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    public Transform bulletSpawnPoint;
    public bullet bulletPrefab;
    public float bulletSpeed = 1f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("fff");
            var bullet = Instantiate(bulletPrefab,bulletSpawnPoint.position,bulletSpawnPoint.rotation);
            bullet.AddDir(bulletSpawnPoint.forward.normalized);
        }
    }
}
