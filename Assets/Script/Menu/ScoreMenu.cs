
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenu:MonoBehaviour
{
    public Text txtName;
    public Text txtstt;
    public Text txtscore;
    public ManagerScore managerScore;
    public int amoutShow;
    public void ShowTop()
    {
        txtName.text = txtscore.text = txtstt.text = "";
        managerScore.ListScore.Sort();
        for (int i = 0; i < (amoutShow <= managerScore.ListScore.Count ? amoutShow : managerScore.ListScore.Count); i++)
        {
            txtstt.text += i + 1 + "\n";
            txtName.text += managerScore.ListScore[i].Name.Trim() +"\n";
            txtscore.text += managerScore.ListScore[i].Values +"\n";
        }
    }
}

