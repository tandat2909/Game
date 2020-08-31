using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerItem
{
    List<Items> listItem = new List<Items>();
    
    Items traVeitem (string NameItem)
    {
        foreach(Items i in listItem)
        {
            if(i.NameItem == NameItem)
            {
                return i;
            }
        }
        return null;
    }
    Items traVeitem(float ID)
    {
        foreach(Items i in listItem)
        {
            if(i.IDItem == ID)
            {
                return i;
            }
        }
        return null;
    }
    void addItem(Items item)
    {
        if (item != null)
        listItem.Add(item);
    }
    void removeItem(Items item)
    {
        if(item != null)
        {
            listItem.Remove(item);
        }
    }

}
