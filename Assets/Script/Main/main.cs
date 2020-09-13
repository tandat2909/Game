using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public int amountCreate;
    //public float TimeCreatEnemy;
    public List<Vector3> listCong;
    
    public bool isCreateEnemy = false;
    
    void Start()
    {
        listCong = new List<Vector3>()
        {
            new Vector3(-0.7f ,3.257f,enemy.transform.position.z),
            new Vector3(5.833f,3.261f,enemy.transform.position.z)
        };
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
                GameObject a = Instantiate(enemy);
                a.transform.position = listCong[Random.Range(0, listCong.Count)];
                yield return new WaitForSeconds(0.5f);
            }
            //yield return new WaitForSeconds(TimeCreatEnemy);

        }
        yield return null;
        StartCoroutine(CreatEnemy());
    }
}
