using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public static Fire instance;
    public float Dame = 5;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        target.gameObject.GetComponent<CircleCollider2D>();
        if(target.gameObject.tag == "wall" || target.gameObject.tag =="tree")
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "wall" || target.gameObject.tag == "tree")
        {
            Destroy(gameObject);
        }
    }
   

}
