using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour,IIncreaseDangger
{
    public ConfigPlayer config;
    public bool status = true;
    public ManagerItem managerItem;
    
    void FixedUpdate()
    {
        try
        {
            if (config.Blood <0)
            {
                Debug.Log("DIe");
                status = false;
                Time.timeScale = 0;
            }
        }
        catch(Exception e) {
            Debug.Log("FixedUpdate Player Error: " + e.Message);
        }
    }
   
    
    void OnTriggerEnter2D(Collider2D item)
    {
        
        if(item.gameObject.tag == "Item")
        {
            Items itemtemp = item.gameObject.GetComponent<Items>();
            //Debug.Log(itemtemp.StatusItem +" ten id " + itemtemp.ID.ToString());
            if (!managerItem.SearchItem(itemtemp.ID).StatusItem)
            {

                ActivateItem(itemtemp);
                item.gameObject.GetComponent<Collider2D>().enabled = false;
                item.gameObject.GetComponent<SpriteRenderer>().enabled = false;

            }
        }
    }
    void ActivateItem(Items item)
    {
        try
        {
            item.StatusItem = true;
            managerItem.ListItem[managerItem.IndexOf(item.ID)] = item;
            GameObject.Find("Item"+item.ID.ToString()).GetComponent<Image>().enabled = true;

            
        }catch(Exception e)
        {
            Debug.Log("fail ActivateItem player: " + e.Message + " " + e.StackTrace );
        }
    }

    public void Add(float thongso)
    {
       config.Damage += thongso;
    }
    public void AddPoint(float point)
    {
        config.Point += point;
    }

}