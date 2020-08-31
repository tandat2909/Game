using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool status = true;
    public float point = 0;
    public Text pointText;
    
    void FixedUpdate()
    {
        if (!status)
        {
            // die do something
            Debug.Log("die");
        }
        pointText.text = formatPoint(point);
    }
    private string formatPoint(float number)
    {
        return number < 9 ? "0000" + number : number < 99 ? "000" + number : number < 999 ? "00" + number : number < 9999 ? "0" + number : "" + number;
    }
}