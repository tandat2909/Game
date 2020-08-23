using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public string enemyName;
    //public bool State = false;
    public float Damage;
  
    public float moveSpeedE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D tag)
    {
        if (tag.gameObject.tag == "Arrow")
        {
            Arrow hit = tag.gameObject.GetComponent<Arrow>();
            if(health - hit.Damage <= 0)
            {
                Destroy(this.gameObject);

            }else
                health -= hit.Damage;

            Destroy(tag.gameObject);
        }
    }

}
