using Assets.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour,IIncreaseDangger
{
    public ConfigPlayer config;
    public ManagerScore managerScore;
    public bool status = true;
    public ManagerItem managerItem;
    
    void FixedUpdate()
    {
        try
        {
            if (config.Blood <= 0)
            {


                managerScore.AddScore(new Score(config.NamePlayer, config.Point));
                Debug.Log("DIe");
                status = false;
                
                GameObject[] destryenemy = GameObject.FindGameObjectsWithTag("Enemy");
                foreach(GameObject i in destryenemy)
                {
                    Destroy(i);
                }
                Time.timeScale = 0;
                StopAllCoroutines();

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
            if (!managerItem.SearchItem(itemtemp.ID).StatusItem && !   GameObject.Find("Item" + itemtemp.ID).GetComponent<Image>().enabled)
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
            GameObject.Find("Item"+item.ID).GetComponent<Image>().enabled = true;

            
        }catch(Exception e)
        {
            Debug.Log("fail ActivateItem player: " + e.Message + " " + e.StackTrace );
        }
        FindObjectOfType<AudioManager>().PlaySound("ColectItems");
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