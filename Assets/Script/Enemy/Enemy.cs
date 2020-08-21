using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public string enemyName;
    public bool State = false;
    public float baseAttack;
    public float moveSpeedE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            State = false;
        }
    }
}
