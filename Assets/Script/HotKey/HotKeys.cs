using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HotKeys : MonoBehaviour
{
    public ManagerItem managerItem;

    void Update()
    {
        try
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                 managerItem.ListItem[managerItem.SearchID(IdItem.Heart)].UseItem();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                 managerItem.ListItem[managerItem.SearchID(IdItem.Shoe)].UseItem();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                 managerItem.ListItem[managerItem.SearchID(IdItem.Dangger)].UseItem();
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (managerItem.ListItem[managerItem.SearchID(IdItem.Ultimate)].UseItem())
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

        }catch(Exception e)
        {
            Debug.Log("HotKey Fail: " + e.ToString());
        }
        
    }


}
