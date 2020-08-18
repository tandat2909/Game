using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearth : MonoBehaviour
{

    public float Blood = 100; //mau 
    public RectTransform mauActive;
    Rect ShowMau;
   
    
    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate()
    {
       
    }
    void OnTriggerEnter2D(Collider2D tager)
    {
        if(tager.tag == "danDich")
        {
           
            Blood -= Fire.instance.Dame;
            ShowMau.width = Blood/2;
            mauActive.rect.Set(ShowMau.x, ShowMau.y, ShowMau.width, ShowMau.height);
            //Destroy(tager.gameObject);
            Debug.Log("blood : " + Blood);
        }
    }
}
