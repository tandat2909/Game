﻿
using System;

using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.UI;

public class ultiMate : Items
{
    public override bool UseItem()
    {
        if (StatusItem)
        {
            
            Bow setUlti = GameObject.Find("Player").GetComponentInChildren<Bow>();
            
            setUlti.UltiActive = true;
            return true;
        }
        return false;
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



    public ultiMate()
    {
        ID = IdItem.Ultimate;
        NameItem = "ItemUltimate";
        //base.ThongSo = 20f;
    }
   

}


