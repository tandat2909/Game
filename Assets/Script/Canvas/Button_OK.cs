using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Button_OK:MonoBehaviour
{
    public InputField inputNamePlayer;
    public ConfigPlayer config;
    //public GameObject Play;
    public void Update()
    {
        
    }
    public void _Click()
    {
        config.NamePlayer = inputNamePlayer.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;

    }
}

