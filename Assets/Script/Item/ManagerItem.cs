using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class ManagerItem
{
    List<Items> listItem = new List<Items>();

    public List<Items> ListItem { get => listItem; }

    public Items SearchItem(string NameItem)
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
   public  Items SearchItem(float ID)
    {
        foreach(Items i in listItem)
        {
            if(i.IdItem == ID)
            {
                return i;
            }
        }
        return null;
    }
    public void AddItem(Items item)
    {
        if (item != null)
        listItem.Add(item);
    }
    public void RemoveItem(Items item)
    {
        if (item != null)
        {
            listItem.Remove(item);

        }
    }
    public void RemoveItem(int index)
    {
        listItem.RemoveAt(index);
    }

}
