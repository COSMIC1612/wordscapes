using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pausemenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gmlvl3.RightWords<8 && !gmlvl3.GameIsOver)
        {
            if(GameIsPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume() 
    {
        pausemenuUI.SetActive(false);
        Time.timeScale=1f;
        GameIsPaused=false;
    }


    void pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale=0f;
        GameIsPaused=true;
    }

    public static void loadMenu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void quitGame()
    {
        Debug.Log("Quitting Game ...");
        Application.Quit();
    }
}
