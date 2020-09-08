
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerItem : MonoBehaviour
{
    public List<Items> ListItem;//=  new List<Items>() { new Blood(), new TangSatThuong(), new TocChay(),new ultiMate() };
    void Awake()
    {
        ListItem = new List<Items>() { new Blood(), new TangSatThuong(), new TocChay(), new ultiMate() };
        //Debug.Log(ListItem[0].IdItem + " id " + ListItem[1].IdItem );
    }
    public int IndexOf(IdItem ID)
    {
        for (int i = 0; i < ListItem.Count; i++)
        {
            if (ID == ListItem[i].ID)
            {
                return i;
            }

        }

        return -1;
    }
    public Items SearchItem(IdItem ID)
    {
        foreach (Items i in ListItem)
        {
            if (ID == i.ID) return i;
        }
        return null;
    }
    void FixedUpdate()
    {
        Bow a = GameObject.Find("Player").GetComponentInChildren<Bow>();
        if (!a.UltiActive)
        {
            if (ListItem != null)
            {
                Items ulti = SearchItem(IdItem.Ultimate);
                if (SearchItem(IdItem.Heart).StatusItem && SearchItem(IdItem.Shoe).StatusItem && SearchItem(IdItem.Dangger).StatusItem)
                {

                    GameObject.Find(ulti.NameItem).GetComponent<Image>().enabled = true;
                    ulti.StatusItem = true;

                }
                else
                {
                    GameObject.Find(ulti.NameItem).GetComponent<Image>().enabled = false;
                    ulti.StatusItem = false;
                }
            }
        }


    }

}
