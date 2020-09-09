
using System;
using UnityEngine;
using UnityEngine.UI;

public class Blood: Items
{
    public override bool UseItem()
    {
        if (StatusItem)
        {
            IHealth health = GameObject.FindWithTag("Player").GetComponent<IHealth>();
            health.AddHealth(base.ThongSo);
            

            
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
    public Blood()
    {
        ID = IdItem.Heart;
       
    }
    
    
}
