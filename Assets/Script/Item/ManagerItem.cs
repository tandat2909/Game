
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
        float sumWeight = 0;
        float randMax = 0;
        foreach (Items i in ListItem)
        {
            randMax += i.weight;
        }
        foreach (Items i in ListItem)
        {
            float rand = Random.Range(1, randMax);

            //Debug.Log("rand: " + rand + "count lisitem:" + ListItem.Count);
            Debug.Log(i.NameItem + " rand " + rand);
            sumWeight = i.weight;
            if (rand < sumWeight)
            {
                if (i.NameItem != "")
                {
                    Debug.Log(i.NameItem +" rand " + rand);
                    foreach (GameObject objItem in lsGOItem)
                    {
                        if (objItem.GetComponent<Items>().ID == i.ID) return objItem;
                    }
                }
                else return null;
                
            }

        }
        //Debug.Log("khong item");
        return null ;

    }


    void FixedUpdate()
    {
        try
        {
            Bow a = GameObject.Find("Player").GetComponentInChildren<Bow>();
            if (!SearchItem(IdItem.Ultimate).StatusItem)
            {
                Items ulti = SearchItem(IdItem.Ultimate);
                if (SearchItem(IdItem.Heart).StatusItem && SearchItem(IdItem.Shoe).StatusItem && SearchItem(IdItem.Dangger).StatusItem)
                {                    
                    GameObject.Find(ulti.NameItem).GetComponent<Image>().enabled = true;
                    ulti.StatusItem = true;
                    FindObjectOfType<AudioManager>().PlaySound("Item4");
                    
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
