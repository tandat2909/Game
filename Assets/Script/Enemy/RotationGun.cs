using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotationGun : MonoBehaviour
{
    public string NameTargetAttack;
    private Transform attackTarget;
    public Transform targetEnemy;
    void Start()
    {
        attackTarget = GameObject.FindGameObjectWithTag(NameTargetAttack).transform;
    }
    void Update()
    {
        // Rotation();
    }
    void Rotation()
    {
        Vector2 lookDir = targetEnemy.position - attackTarget.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        this.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}

