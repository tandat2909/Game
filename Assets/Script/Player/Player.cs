using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool status = true;
    public float point = 0;
    public Text pointText;
    ManagerItem managerItem;

   

    void Awake()
    {
        managerItem = new ManagerItem();
    }

    void FixedUpdate()
    {
        if (!status)
        {
            // die do something
            Debug.Log("die");
            Time.timeScale = 0;
        }
        pointText.text = formatPoint(point);
    }
    private string formatPoint(float number)
    {
        return number < 9 ? "0000" + number : number < 99 ? "000" + number : number < 999 ? "00" + number : number < 9999 ? "0" + number : "" + number;
    }
    
    void OnTriggerEnter2D(Collider2D item)
    {
        if(item.gameObject.tag == "Item")
        {
            Items itemtemp = item.gameObject.GetComponent<Items>();
            managerItem.AddItem(itemtemp);
            GameObject.Find("ItemMau").GetComponent<Image>().sprite = itemtemp.SourceImg;
            //item.gameObject.SetActive(false);
            Destroy(item.gameObject);
            if(managerItem.ListItem.Count > 0)
            {
              //  Debug.Log("add item thanh cong");
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            useItem(1);
           
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            useItem(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            useItem(3);
        }

    }

    void useItem(int index)
    {
        try
        {
            Items used = managerItem.ListItem[index - 1];
            used.UseItem();
            //managerItem.ListItem.Remove(used);
         
           
        }
        catch (ArgumentOutOfRangeException e)
        {
            //Debug.Log("Không có Item dùng cái gì ?? " + e.Message + " " + e.ParamName);
        }

    }


}