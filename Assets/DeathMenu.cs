using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsEnd = false;
    public GameObject deathMenuUI;
    public GameObject deathMenuBackGr;
    public ManagerScore managerScore;


    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Player").GetComponent<Player>().status)
        {
            death();
           
            ShowHight();
        }
    }
    private void death() {
        deathMenuUI.SetActive(true);
        deathMenuBackGr.SetActive(true);
    }

    void ShowHight()
    {
       
        GameObject[] listScore = GameObject.FindGameObjectsWithTag("ScoreHight");
        managerScore.ListScore.Sort();
        Debug.Log("count showhight: " + managerScore.ListScore.Count);
        for(int i = 0; i < listScore.Length; i++)
        {
            if(listScore[i].name.IndexOf(i+1 +"") != -1)
            {
                listScore[i].GetComponent<IScore>().ShowScore(managerScore.ListScore[i]);
                
            }
            
        }
    }

}
