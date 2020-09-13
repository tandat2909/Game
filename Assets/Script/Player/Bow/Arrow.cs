using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float Damage;


    void OnTriggerEnter2D(Collider2D tag)
    {
        if (tag.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
        if(tag.gameObject.tag == "Enemy")
        {
            tag.gameObject.GetComponent<IHealth>().TakeDamage(Damage);
            FindObjectOfType<AudioManager>().PlaySound("Hitting");
            Destroy(this.gameObject);
        }
       
    }
}
