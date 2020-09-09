using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour,IIncreaseDangger
{
    public bool status = true;
    public float point = 0;
    public Text pointText;
    public float Damage;
    public ManagerItem managerItem;
    
    void FixedUpdate()
    {
        if (!status)
        {
            // die do something
            Debug.Log("die");
            Time.timeScale = 0;
        }
        pointText.text = point.ToString();
    }
   
    
    void OnTriggerEnter2D(Collider2D item)
    {
        
        if(item.gameObject.tag == "Item")
        {
            Items itemtemp = item.gameObject.GetComponent<Items>();
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
            Debug.Log("fail ActivateItem: " + e.Message + " " + e.StackTrace );
        }
    }

    public void Add(float thongso)
    {
        Damage += thongso;
    }
}