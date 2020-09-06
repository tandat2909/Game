using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangSatThuong : Items
{
    public override void UseItem()
    {
        Arrow arrow = GameObject.FindWithTag("Player").GetComponentInChildren<Bow>().arrow.GetComponent<Arrow>();
        arrow.Damage += base.ThongSo;
        
        
    }

    void Awake()
    {
        NameItem = "TangSatThuong";
        //base.ThongSo = 20f;
    }

}


