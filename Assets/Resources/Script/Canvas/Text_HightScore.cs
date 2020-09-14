
using Assets.Data;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Text_HightScore : MonoBehaviour,IScore
{
    public Text textName;
    public Text TextScore;

    void Start()
    {
      //  updateValue();
    }
    void FixedUpdate()
    {
        //updateValue();
    }

    private void updateValue(Score a)
    {
        textName.text = a.Name;
        TextScore.text = a.Values.ToString();
    }

    public void ShowScore(string name, float score)
    {
        textName.text = name;
        TextScore.text = score.ToString();
    }

    public void ShowScore(Score score)
    {
        updateValue(score);
    }

    public void ShowScore(float score)
    {
       
    }
}
