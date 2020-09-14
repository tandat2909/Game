using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IHealth
{
    public float health;
    public string enemyName;
    public Animator animator;
    public float DamageEnemy;
    public float moveSpeedE;
    private Transform target;
    public float chaseRadius;
    public float attackRadius;
    public float pointEnemy;
    public ConfigPlayer config;
    private int countEnemyDie = 0;


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

    public void TakeDamage(float damage)
    {
        animator.SetTrigger("Hurt");
        if (health - damage <= 0)
        {
            moveSpeedE = 0;
            animator.SetBool("Death", true);
            gameObject.GetComponent<Collider2D>().isTrigger = true;
            this.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

            StartCoroutine(Des(this.gameObject));

        }
        else
            health -= damage;

        
    }
    IEnumerator Des(GameObject enemy)
    {
        yield return new WaitForSeconds(0.7f);

        config.Point += pointEnemy;
        if (countEnemyDie++ == 6)
        {
            countEnemyDie = 0;
            DropItem();
        }
        Destroy(enemy);

    }

    void DropItem()
    {
        GameObject drop = GameObject.Find("Main").GetComponent<ManagerItem>().GetItemDrop();
        if (drop != null)
        {
            Instantiate(drop);
            drop.transform.position = this.transform.position;
        }
    }
    public void AddHealth(float addHealth)
    {
        health += addHealth;
    }
}
