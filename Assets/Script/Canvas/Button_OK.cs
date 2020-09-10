using UnityEngine;
using UnityEngine.UI;
public class Button_OK:MonoBehaviour
{
    public InputField inputNamePlayer;
    public GameObject Canvas_NamePlayer;
    public ConfigPlayer config;
    public GameObject Play;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            _Click();
        }
    }
    public void _Click()
    {
        config.NamPlayer = inputNamePlayer.text;
        Canvas_NamePlayer.SetActive(false);
        Play.SetActive(true);
    }
}

