
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerItem : MonoBehaviour
{
    public List<Items> ListItem =  new List<Items>() { new Blood(), new TangSatThuong(), new TocChay(),new ultiMate() };
    public List<GameObject> lsGOItem;
    void Awake()
    {
        //ListItem.Clear();
        //foreach (GameObject item in lsGOItem)
        //{
        //    Items temp = item.GetComponent<Items>();
        //    ListItem.Add(temp);
        //}
        //ListItem.Add(new ultiMate());

    }
    void Start()
    {
        ListItem.Clear();
        foreach (GameObject item in lsGOItem)
        {
            Items temp = item.GetComponent<Items>();
            ListItem.Add(temp);
        }
        ListItem.Add(new ultiMate());
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


    public GameObject GetItemDrop()
    {
        #region code random last
        //float sumWeight = 0;
        //float randMax = 0;
        //foreach (Items i in ListItem)
        //{
        //    randMax += i.weight;
        //}
        //foreach (Items i in ListItem)
        //{
        //    float rand = Random.Range(1, randMax);

        //    //Debug.Log("rand: " + rand + "count lisitem:" + ListItem.Count);

        //    sumWeight = i.weight;
        //    if (rand < sumWeight)
        //    {
        //        if (i.NameItem != "")
        //        {

        //            foreach (GameObject objItem in lsGOItem)
        //            {
        //                if (objItem.GetComponent<Items>().ID == i.ID) return objItem;
        //            }
        //        }
        //        else return null;

        //    }

        //}
        ////Debug.Log("khong item");
        //return null ;
        #endregion
        try
        {
            GameObject a = lsGOItem[Random.Range(0, lsGOItem.Count)];
            return a;
        }
        catch
        {
            return null;
        }
    }


    void FixedUpdate()
    {
        try
        {
            Bow a = GameObject.Find("Player").GetComponentInChildren<Bow>();
            if (!a.UltiActive)
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
        catch { }


    }

}
