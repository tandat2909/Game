using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearth : MonoBehaviour
{

    public Slider sliderBlood;
    
    private float Blood;
    
   
    void Start()
    {
        //Blood = Player.instance.Blood;
        sliderBlood.maxValue = Blood;
        sliderBlood.value = Blood;
        
    }
    public void _NoClickChanged()
    {
        sliderBlood.value = Blood;
    }
   
}
