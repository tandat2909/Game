using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TangSatThuong : Items
{
    public override bool UseItem()
    {
        if (StatusItem)
        {
            Arrow arrow = GameObject.FindWithTag("Player").GetComponentInChildren<Bow>().arrow.GetComponent<Arrow>();
            arrow.Damage += base.ThongSo;
           
          
        }
        return TurnOffItem();
    }
    public override bool TurnOffItem()
    {
        try
        {
            StatusItem = false;
            GameObject.Find("Item" + ID.ToString()).GetComponent<Image>().enabled = false;
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public TangSatThuong() {
        ID = IdItem.Dangger;
       
    }

}


