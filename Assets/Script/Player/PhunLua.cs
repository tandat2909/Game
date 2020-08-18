using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhunLua : MonoBehaviour
{
    public Transform phunLua;
    public GameObject Fire;
    public float speed;
    public float SLFire;
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            for(int i = 0; i< SLFire;i++)
             phun();
        }
    }
   
    void phun()
    {
        GameObject fire = Instantiate(Fire, phunLua.position, phunLua.rotation);
        Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
        rb.AddForce(phunLua.up * speed, ForceMode2D.Impulse);
    }
}
