using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("LevelSelect");//SceneManager.GetActiveScene().buildIndex + 1

        
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public GameObject optionscreen;
    public void OpenOptions()
    {
        optionscreen.SetActive(true);
    
    }
    public void CloseOptions()
    {
        optionscreen.SetActive(false);
    }
   
}
