using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TangSatThuong : Items
{
    [SerializeField]
    private float TimerUse;
    private IIncreaseDangger arrow;
    public override bool UseItem()
    {
        if (StatusItem)
        {
            arrow = GameObject.FindWithTag("Player").GetComponent<IIncreaseDangger>();//.arrow.GetComponent<Arrow>();
            arrow.Add(ThongSo);
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
        arrow.Add(-ThongSo);
        TurnOffItem();

    }

    public override bool TurnOffItem()
    {
        try
        {

            //StopCoroutine(setTimes());
            StatusItem = false;
            GameObject.Find("TimerDangger").GetComponent<ShowTimes>().Show("");
            GameObject.Find("Item" + ID.ToString()).GetComponent<Image>().enabled = false;
            Destroy(this.gameObject);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public TangSatThuong()
    {
        ID = IdItem.Dangger;

    }

}


