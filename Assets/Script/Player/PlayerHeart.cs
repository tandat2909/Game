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
    void FixedUpdate()
    {
        
        if (Blood <= 0)
        {
            sliderBlood.value = 0;
            Player die = GetComponent<Player>();
            die.status = false;
           
        }else
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

    public void _NoClickChanged()
    {
        sliderBlood.value = Blood;
    }



   
}
