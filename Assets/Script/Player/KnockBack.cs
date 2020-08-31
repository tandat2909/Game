﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KnockBack : MonoBehaviour
{
    // Start is called before the first frame update
    // Hiệu ứng đánh trúng enemy lùi lại;
    public float thurst;
    public float knockTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Rigidbody2D enemy = other.GetComponent<Rigidbody2D>();
            if (enemy != null)
            {
                
                Vector2 difference = enemy.transform.position ;
                difference = difference.normalized * thurst ;
                enemy.velocity = new Vector2(-1f, -1f)*thurst;
                StartCoroutine(KnockCo(enemy));
                
            }
        }
    }
    IEnumerator KnockCo(Rigidbody2D enemy)
    {
        if(enemy != null)
        {
            yield return new WaitForSeconds(knockTime);
            enemy.velocity = Vector2.zero;
            
        }
    }
}
