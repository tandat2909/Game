using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public string enemyName;
    public Animator animator;
    //public bool State = false;
    
   
    public float moveSpeedE;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D tag)
    {
        
        if (tag.gameObject.tag == "Arrow")
        {
            animator.SetTrigger("Hurt");
            Arrow hit = tag.gameObject.GetComponent<Arrow>();
            if(health - hit.Damage <= 0)
            {
                
                moveSpeedE = 0;
                animator.SetBool("Death", true);
                gameObject.GetComponent<Collider2D>().isTrigger = true;
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                StartCoroutine(Des(this.gameObject));

            }else
                health -= hit.Damage;

            Destroy(tag.gameObject);
        }
    }

    IEnumerator Des(GameObject enemy) {
        yield return new WaitForSeconds(0.7f);
        Destroy(enemy);
        Player AddPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        AddPoint.point += 10;
        
    }

    private Transform target;
    public float chaseRadius;
    public float attackRadius;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
        //Rigidbody2D rbenemy = GetComponent<Rigidbody2D>();
        //rbenemy.velocity = new Vector2(0, 0);
    }
    void CheckDistance()
    {
        float moveTemp = moveSpeedE;
        if (Vector3.Distance(target.position, transform.position) <= attackRadius)
        {
            moveTemp = 0;
        }
      
       if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {

            transform.position = Vector3.MoveTowards(transform.position, target.position, moveTemp * Time.deltaTime);
        }
       
    }

    
}
