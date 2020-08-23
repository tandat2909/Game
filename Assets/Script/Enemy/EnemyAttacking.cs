using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttacking : MonoBehaviour
{
    // Start is called before the first frame update
    public float DamageAttack;

    public Transform attackTarget;
    public Transform targetEnemy;

    void Start()
    {
        attackTarget = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
    
    void Rotation()
    {
        Vector2 lookDir = targetEnemy.position - attackTarget.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        this.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

}
