using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KnockBack : MonoBehaviour
{
    // Start is called before the first frame update
    // Hiệu ứng đánh trúng enemy lùi lại;
    public float thurst;
    public float knockTime;
    private bool lockVelocity = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lockVelocity)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            lockVelocity = false;
            //Debug.Log("ban trung ne");
            Rigidbody2D enemy = gameObject.GetComponent<Rigidbody2D>();
            Vector2 posPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
            Vector2 posEnemy = enemy.transform.position;
            //Debug.Log(tranfplayer.position);
            Vector2 difference = posEnemy - posPlayer;
            difference = difference.normalized * thurst;
            enemy.AddForce(difference,ForceMode2D.Force);
            StartCoroutine(KnockCo());
        }
    
    }
    IEnumerator KnockCo()
    {
        yield return new WaitForSeconds(knockTime);
       // Debug.Log("tam dun ok");
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        lockVelocity = true;
    }
}
