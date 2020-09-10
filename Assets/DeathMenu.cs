using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsEnd = false;
    public GameObject deathMenuUI;
    public GameObject deathMenuBackGr;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (!GameObject.Find("Player").GetComponent<Player>().status)
        {
            death();
        }
    }
    private void death() {
        deathMenuUI.SetActive(true);
        deathMenuBackGr.SetActive(true);
    }

}
