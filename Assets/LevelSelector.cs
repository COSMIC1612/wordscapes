using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;
    public Button[] levelButtons;

    void Start()
    {
        //int levelReached=PlayerPrefs.GetInt("levelReached",1);
        if(gmScript.lvl2verif)
        {
            levelButtons[1].interactable=true;
        }
        else
        {
            levelButtons[1].interactable=false;
        }
        /*for(int i=1;i<levelButtons.Length;i++)
        {
            if(i+1>levelReached)
             levelButtons[i].interactable=false;
        }*/
        if(gmlvl2.lvl3verif)
        {
            levelButtons[2].interactable=true;
        }
        else
        {
            levelButtons[2].interactable=false;
        }
    }

    public void Select (string levelName)
    {
        fader.FadeTo(levelName);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            pausemenu.loadMenu();
    }
}
