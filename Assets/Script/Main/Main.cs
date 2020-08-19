using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject itemBlood;
  

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("CreatItemMau");
        
    }
    IEnumerator CreatItemMau()
    { 
       yield return new WaitForSeconds(10f);
        GameObject a =  Instantiate(itemBlood);
        a.transform.position = new Vector3(Random.Range(1, 100), Random.Range(1, 100), 0);

    }

    
}
