using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMole : Enemy
{
    
    private Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }
    void CheckDistance()
    {
        if (State)
            if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
            {
             
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            }
    }
    void OnTriggerEnter2D(Collider2D tag)
    {
        if(tag.gameObject.tag == "Player")
        {
            State= true;
        }
    }
   
    void OnTriggerExit2D(Collider2D tag)
    {
        if(tag.gameObject.tag == "Player")
        {
            State = false;
        }
    }



}
