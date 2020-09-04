using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeart : MonoBehaviour
{
    public Slider sliderBlood;
    
    public float Blood = 100;
    public float MaxBlood = 100;
    
    
    void Start()
    {
        
        sliderBlood.maxValue = MaxBlood;
        sliderBlood.value = MaxBlood;
        
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
    


    public void _NoClickChanged()
    {
        sliderBlood.value = Blood;
    }



   
}
