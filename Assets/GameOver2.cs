using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    //public SceneFader sceneFader;

    public void LoadingLevel()
    {
        Time.timeScale=1f;
        Debug.Log("To The Next Level ...");
        SceneManager.LoadScene("Level03");
    }



    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
    }

    
    public void Menu()
    {
        Time.timeScale=1f;
        Debug.Log("Go To The Menu");
        SceneManager.LoadScene("Main Menu");
    }
}