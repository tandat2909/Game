using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTimes : MonoBehaviour,IShowTimes
{
    Text txt;
    public void Show(string times)
    {
        if (txt != null && txt.enabled)
            this.gameObject.GetComponent<Text>().text = times;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        txt = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
}
