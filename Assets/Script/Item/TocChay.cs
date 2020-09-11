
using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TocChay : Items
{
    [SerializeField]
    private float TimerUse;
    IIncreaseShoe movement;
    public override bool  UseItem()
    {
        if (StatusItem)
        {
            UsingSound();
            movement = GameObject.FindWithTag("Player").GetComponent<IIncreaseShoe>();
            movement.Add(ThongSo);
            //StatusItem = false;    
            StartCoroutine(setTimes());
            return true;
        }
        else
            return false;
    }


    IEnumerator setTimes()
    {
        for (float i = TimerUse; i >= 0; i--)
        {
             
            GameObject.Find("Timer" + ID.ToString()).GetComponent<ShowTimes>().Show(i.ToString());
            yield return new WaitForSecondsRealtime(1f);

        }
        movement.Add(-ThongSo);
        //Debug.Log()
        TurnOffItem();

    }

    public override bool TurnOffItem()
    {
        try
        {
            
            GameObject.Find("Timer" + ID.ToString()).GetComponent<ShowTimes>().Show("");
            GameObject.Find("Item" + ID.ToString()).GetComponent<Image>().enabled = false;
            StatusItem = false;
            Destroy(this.gameObject);
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
