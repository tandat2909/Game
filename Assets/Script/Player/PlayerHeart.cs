using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeart : MonoBehaviour
{
    public Slider sliderBlood;
    
    public float Blood = 100;
    
    
    void Start()
    {
        
        sliderBlood.maxValue = Blood;
        sliderBlood.value = Blood;
        
    }
    
    void OnTriggerEnter2D(Collider2D target)
    {
        
        if (target.gameObject.tag == "itemMau")
        {
           if(Blood + 50 >= sliderBlood.maxValue)
            {
                Blood = 100;
            }else
            Blood += 50;
           
            Destroy(target.gameObject);
        }
        sliderBlood.value = Blood;

    }
   void  OnCollisionEnter2D(Collision2D target)
    {
        Onshoot(target.gameObject);
       
        
    }



    void Onshoot(GameObject target)
    {
        if (target.tag == "Enemy")
        {
            Enemy enm = target.gameObject.GetComponent<Enemy>();

            if (enm != null)
            {
                float DamageEnemy = enm.Damage;
                if (Blood - DamageEnemy <= 0)
                {
                    Blood = 0;
                }
                else
                    Blood -= DamageEnemy;
            }
            sliderBlood.value = Blood;
        }
    }
    public void _NoClickChanged()
    {
        sliderBlood.value = Blood;
    }



   
}
