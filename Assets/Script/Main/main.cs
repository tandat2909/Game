using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float TimeCreatEnemy;
    
    public bool isCreatEnemy = false;
    
    void Start()
    {
            
        if (isCreatEnemy)
        {
            StartCoroutine(CreatEnemy());
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator CreatEnemy()
    {
        if (isCreatEnemy)
        {
            GameObject a = Instantiate(enemy);
            a.transform.position = new Vector3(Random.Range(-5.8f, 6.4f), Random.Range(-2.8f, 3.4f), enemy.transform.position.z);
            yield return new WaitForSeconds(TimeCreatEnemy);

        }
        yield return null;
        StartCoroutine(CreatEnemy());
    }
}
