
using System;
using UnityEngine;
using UnityEngine.UI;

public class TocChay : Items
{
    public override bool  UseItem()
    {
        if (StatusItem)
        {
            PlayerMovement movement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
            movement.moveSpeed += ThongSo;
                      
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
    public TocChay()
    {
        ID = IdItem.Shoe;   
      
    }

}
