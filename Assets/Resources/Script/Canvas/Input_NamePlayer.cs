using UnityEngine;
using UnityEngine.UI;
public class Input_NamePlayer : MonoBehaviour
{
    public InputField inputNamePlayer;
    public GameObject btnOk;
    void Update()
    {

    }

    public void TextChange()
    {
        if (inputNamePlayer.text != "")
        {

            btnOk.SetActive(true);

        }
        else btnOk.SetActive(false);
    }

}
