using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuBackGr;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
                Resume();
            else
                Pause();
        }
    }
    public void Resume() {
        pauseMenuUI.SetActive(false);
        pauseMenuBackGr.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause() {
        pauseMenuUI.SetActive(true);
        pauseMenuBackGr.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void PlayAgain() {   
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}
