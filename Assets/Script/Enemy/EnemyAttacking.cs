using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttacking : MonoBehaviour
{
    // Start is called before the first frame update

    public string NameTargetAttack;
    private Transform attackTarget;
    public float DamageEnemy;
    private bool attack = false;

    void Start()
    {
        attackTarget = GameObject.FindGameObjectWithTag(NameTargetAttack).transform;
        StartCoroutine(AttackPlayer());
      
    }

    void OnCollisionEnter2D(Collision2D target)
    {
       // Onshoot(target.gameObject);
       if(target.gameObject.tag == "Player")
        {
            attack = true;
        }
    }
    void OnCollisionExit2D(Collision2D target)
    {
        // Onshoot(target.gameObject);
        if (target.gameObject.tag == "Player")
        {
            attack = false;
        }
    }

    IEnumerator AttackPlayer()
    {
        if (attack)
        {
            Onshoot(attackTarget.gameObject);
            yield return new WaitForSeconds(1f);
            
        }
        yield return null;
        StartCoroutine(AttackPlayer());
    }
   

   
    void Onshoot(GameObject target)
    {
        
        if (target.tag == "Player")
        {
            PlayerHeart heartPlayer = target.GetComponent<PlayerHeart>();
            if (heartPlayer.Blood - DamageEnemy <= 0)
            {
                heartPlayer.Blood = 0;
                
            }
                
            else
                heartPlayer.Blood -= DamageEnemy;

        }
    }

}
