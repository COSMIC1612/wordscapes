using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompleteLevel : MonoBehaviour
{
    public void LoadingLevel()
    {
        Time.timeScale=1f;
        Debug.Log("To The Next Level ...");
        SceneManager.LoadScene("Level02");
    }
    
}
