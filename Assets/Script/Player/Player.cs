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
            ActivateItem(itemtemp);
            Destroy(item.gameObject);
            
        }
    }
    void ActivateItem(Items item)
    {
        try
        {
            item.StatusItem = true;
            managerItem.ListItem[managerItem.SearchID(item.ID)] = item;
            GameObject.Find(item.NameItem.Trim()).GetComponent<Image>().enabled = true;

            
        }catch(Exception e)
        {
            Debug.Log("fail ActivateItem: " + e.Message + " " + e.StackTrace + " " + managerItem.SearchID(item.ID));
        }
    }


}