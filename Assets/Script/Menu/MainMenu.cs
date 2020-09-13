
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    void Start() {
        FindObjectOfType<AudioManager>().PlaySound("MenuTheme");
    }
    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }
    public void QuitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void ButtonSound()
    {
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }
}
