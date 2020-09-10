
using System;
using UnityEngine;
using UnityEngine.UI;

public class Text_Point : MonoBehaviour
{
    public Text textPoint;
    public ConfigPlayer config;
    
    void FixedUpdate()
    {
        updateValuePoint();
    }

    private void updateValuePoint()
    {
        textPoint.text = config.Point.ToString();
    }
}
