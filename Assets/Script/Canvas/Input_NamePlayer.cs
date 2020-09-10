using UnityEngine;
using UnityEngine.UI;
public class Input_NamePlayer : MonoBehaviour
{
    public InputField inputNamePlayer;
    public GameObject btnOk;

    public void TextChange()
    {
        if (inputNamePlayer.text != "")
        {
            Debug.Log("texxchan");
            btnOk.SetActive(true);
        }
        else btnOk.SetActive(false);
    }

}

