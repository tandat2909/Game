
using System;

using UnityEngine;
using UnityEditor;
using System.Collections;

public class ultiMate : Items
{
    public override void UseItem()
    {

        Bow setUlti = GameObject.Find("Player").GetComponentInChildren<Bow>();
        setUlti.amoutUlti = ThongSo >=0 ? ThongSo : 0;
        setUlti.UltiActive = true;

    }
    

    void Awake()
    {
        NameItem = "UltiMate";
        //base.ThongSo = 20f;
    }
   

}


