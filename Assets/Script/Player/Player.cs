using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider sliderBlood;
    public static Player instance;
    public float Blood = 100;
    public string TruMauCuaAi = "BulletAI";
    void Start()
    {
        
        sliderBlood.maxValue = Blood;
        sliderBlood.value = Blood;
        instance = this;

    }
    
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == TruMauCuaAi)
        {
            if(Blood <= 0)
            {
                Blood = 0;
            }else
            Blood -= Bullet.instance.Damage;
            sliderBlood.value = Blood;
        }
        if (target.gameObject.tag == "itemMau")
        {
           if(Blood + 50 >= sliderBlood.maxValue)
            {
                Blood = 100;
            }else
            Blood += 50;
            sliderBlood.value = Blood;
            Destroy(target.gameObject);
        }
      
    }

    public void _NoClickChanged()
    {
        sliderBlood.value = Blood;
    }



   
}
