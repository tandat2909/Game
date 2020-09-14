using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy = null;
    public int amountCreate;
    
    public List<GameObject> lsGate;
    
    public bool isCreateEnemy = false;
    
    void Start()
    {
       
      
      StartCoroutine(CreatEnemy());
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] listEnmeyLiving = GameObject.FindGameObjectsWithTag("Enemy");
        isCreateEnemy = listEnmeyLiving.Length == 0 ?true: false;
    }
    IEnumerator CreatEnemy()
    {
        if (isCreateEnemy && GameObject.Find("Player").GetComponent<Player>().status)
        {
           // int pos = Random.Range(0, listCong.Count);
            //Debug.Log(pos);
            amountCreate += 5;
            //Debug.Log(amountCreate);
            for (int i = 1; i <= amountCreate; i++)
            {
                GameObject Gate = lsGate[Random.Range(0, lsGate.Count)];
                Gate.SetActive(true);
                GameObject a = Instantiate(enemy);
                a.transform.position = Gate.transform.position;
                yield return new WaitForSeconds(0.5f);
                Gate.SetActive(false);
                
            }
            //yield return new WaitForSeconds(TimeCreatEnemy);

        }
        yield return null;
        StartCoroutine(CreatEnemy());
    }
}
