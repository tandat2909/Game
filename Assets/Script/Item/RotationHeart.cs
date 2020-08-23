using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHeart : MonoBehaviour
{
    Vector3 rotationss;
    void Start()
    {
        rotationss = Vector3.zero;
        StartCoroutine(asd());
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator asd()
    {
        yield return null;
        rotationss.y += 6f + Time.deltaTime;    
        if(rotationss.y >= 180f)
        {
            rotationss = Vector3.zero;
        }
        this.transform.eulerAngles = rotationss ;
        StartCoroutine(asd());
    }
}
