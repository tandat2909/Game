using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform tranfGun;
    public GameObject Bullet;
    public float speedBullet;
    public float amoutBullet;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < amoutBullet; i++)
                Shoot();
        }
    }

    void Shoot()
    {
        GameObject fire = Instantiate(Bullet, tranfGun.position, tranfGun.rotation);
        Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
        rb.AddForce(tranfGun.up * speedBullet, ForceMode2D.Impulse);
    }
}
