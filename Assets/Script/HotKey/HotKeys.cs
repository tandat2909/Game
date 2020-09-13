using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HotKeys : MonoBehaviour
{
    public ManagerItem managerItem;

    void Update()
    {
        if (GameObject.Find("Player").GetComponent<Player>().status)
            try
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    
                    managerItem.SearchItem(IdItem.Heart).UseItem();


                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    managerItem.SearchItem(IdItem.Shoe).UseItem();
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    managerItem.SearchItem(IdItem.Dangger).UseItem();
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    if (managerItem.SearchItem(IdItem.Ultimate).UseItem())
                    {
                        managerItem.ListItem.ForEach(i =>
                        {
                            if (i.ID != IdItem.Ultimate)
                            {
                                i.TurnOffItem();
                            }
                        });
                    }

                }

            } catch (Exception e)
            {
                Debug.Log("HotKey Fail: " + e.ToString());
            }

    } 
}


