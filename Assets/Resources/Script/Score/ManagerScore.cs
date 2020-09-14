
using Assets.Data;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ManagerScore: ScriptableObject
{
   
   public List<Score> ListScore;
   public bool AddScore(Score a)
    {
        if (a != null & a.Name != null && a.Values >= 0)
        {
            ListScore.Add(a);
            ListScore.Sort();
           
            return ReadWrite.addScore(a);

        }
        else return false;
    }
   
}

