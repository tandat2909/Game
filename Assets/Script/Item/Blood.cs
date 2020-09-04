using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood: Items
{
    public override void UseItem()
    {
        PlayerHeart heart = GameObject.FindWithTag("Player").GetComponent<PlayerHeart>();
       
        heart.Blood = heart.Blood + base.ThongSo >= heart.MaxBlood?heart.MaxBlood: heart.Blood+ base.ThongSo ;
    }

    void Awake()
    {
        NameItem = "Blood";
        //base.ThongSo = 20f;
    }
    
}
