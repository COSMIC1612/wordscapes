using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public SceneFader sceneFader;




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