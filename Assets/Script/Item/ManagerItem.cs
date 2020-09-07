
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerItem:MonoBehaviour
{
    public List<Items> ListItem { get; set; }
    void Start()
    {
        ListItem = new List<Items>() { new Blood(), new TangSatThuong(), new TocChay(),new ultiMate() };
        //Debug.Log(ListItem[0].IdItem + " id " + ListItem[1].IdItem );
    }
    public int SearchID(IdItem ID)
    {
        for(int i = 0; i < ListItem.Count; i++)
        {
            if(ID == ListItem[i].ID)
            {
                return i;
            }
            
        }
        
        return -1;
    }
   
    void FixedUpdate()
    {
        Bow a = GameObject.Find("Player").GetComponentInChildren<Bow>();
        if (!a.UltiActive)
        {
            Items ulti = ListItem[SearchID(IdItem.Ultimate)];
            if (ListItem[SearchID(IdItem.Heart)].StatusItem && ListItem[SearchID(IdItem.Shoe)].StatusItem && ListItem[SearchID(IdItem.Dangger)].StatusItem)
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
