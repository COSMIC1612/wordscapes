using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gmlvl3 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public Transform letter1;
    public Transform letter2;
    public Transform letter3;
    public Transform letter4;
    public Transform letter5;
    public Transform letter6;
    public Transform letter7;
    public Transform letter8;
    public Transform letter9;
    public Transform letter10;
    public Transform letter11;
    public Transform letter12;
    public Transform letter13;
    public Transform letter14;
    public Transform letter15;
    public Transform letter16;
    public Transform letter17;
    public Transform letter18;
    public Transform letter19;
    public Transform bottomL1Obj;
    public Transform bottomL2Obj;
    public Transform bottomL3Obj;
    public Transform bottomL4Obj;
    public static List<string> availLetter1 = new List<string> () {"T"};
    public static List<string> availLetter2 = new List<string> () {"E"};
    public static List<string> availLetter3 = new List<string> () {"B"};
    public static List<string> availLetter4 = new List<string> () {"A"};
    public KeyCode RMB;
    public int wordLen;
    public static string word35L="TAB";
    public static string word34L="BET";
    public static string word33L="TEA";
    public static string word32L="ATE"; 
    public static string word31L="BAT";
    public static string word3L="EAT";
    public static string word4L="BETA";
    public static string word41L="BEAT";
    public static List<string> selectLetter = new List<string> () {"","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","",""};
    public static int letterNum=0;
    public GameObject GameOverUI;
    public static bool GameIsOver;
    public static int RightWords=0;
    public GameObject LevelWonUI;
    public static bool LevelIsWon;
    



    // Start is called before the first frame update
    void Start()
    {
    LevelIsWon=false;
    GameIsOver=false;
    bottomL1Obj.GetComponent<TextMesh>().text=availLetter1[0];
    bottomL2Obj.GetComponent<TextMesh>().text=availLetter2[0];
    bottomL3Obj.GetComponent<TextMesh>().text=availLetter3[0];
    bottomL4Obj.GetComponent<TextMesh>().text=availLetter4[0];

        
    }

    // Update is called once per frame
    void Update()
    {
        spelledWord.GetComponent<TextMesh>().text=currentWord;

        if(Input.GetKeyDown(RMB))
        {
            wordLen = currentWord.Length;
            if(wordLen == 3)
            {
            if(currentWord == word3L)
             {
                letter11.GetComponent<TextMesh>().text=selectLetter[1];
                letter12.GetComponent<TextMesh>().text=selectLetter[2];
                letter10.GetComponent<TextMesh>().text=selectLetter[3];
                RightWords++; 
             }
             else if(currentWord == word31L)
             {
                letter1.GetComponent<TextMesh>().text=selectLetter[1];
                letter5.GetComponent<TextMesh>().text=selectLetter[2];
                letter10.GetComponent<TextMesh>().text=selectLetter[3];
                RightWords++; 
             }
           
             else if(currentWord == word32L)
             {
                letter12.GetComponent<TextMesh>().text=selectLetter[1];
                letter13.GetComponent<TextMesh>().text=selectLetter[2];
                letter16.GetComponent<TextMesh>().text=selectLetter[3];
                RightWords++; 
             }
              else if(currentWord == word33L)
             {
                letter9.GetComponent<TextMesh>().text=selectLetter[1];
                letter14.GetComponent<TextMesh>().text=selectLetter[2];
                letter19.GetComponent<TextMesh>().text=selectLetter[3];
                RightWords++; 
             }
              else if(currentWord == word34L)
             {
                letter7.GetComponent<TextMesh>().text=selectLetter[1];
                letter8.GetComponent<TextMesh>().text=selectLetter[2];
                letter9.GetComponent<TextMesh>().text=selectLetter[3];
                RightWords++; 
             }
              else if(currentWord == word35L)
             {
                letter3.GetComponent<TextMesh>().text=selectLetter[1];
                letter6.GetComponent<TextMesh>().text=selectLetter[2];
                letter7.GetComponent<TextMesh>().text=selectLetter[3];
                RightWords++; 
             }
            
             else
             {
                Debug.Log("wrong 3L word");
             }
            }
            
            else if(wordLen == 4)
            {
            if(currentWord == word4L)
            {
                letter1.GetComponent<TextMesh>().text=selectLetter[1];
                letter2.GetComponent<TextMesh>().text=selectLetter[2];
                letter3.GetComponent<TextMesh>().text=selectLetter[3];
                letter4.GetComponent<TextMesh>().text=selectLetter[4];
                RightWords++;
            }
            else if(currentWord == word41L)
            {
                letter15.GetComponent<TextMesh>().text=selectLetter[1];
                letter16.GetComponent<TextMesh>().text=selectLetter[2];
                letter17.GetComponent<TextMesh>().text=selectLetter[3];
                letter18.GetComponent<TextMesh>().text=selectLetter[4];
                RightWords++;
            }
            else
            {
               Debug.Log("wrong 4L word");      
            }
            }
            else 
            {
                Debug.Log("wrong word");
            }
            currentWord ="";
            letterNum=0;
            
        }
        if (GameIsOver)
            return;
        if(CountDownTimer3.CurrentTime==0 && RightWords<8)    
            EndGame(); 
        
        if(RightWords==8)
        {
           LevelWon();
           Time.timeScale=0f;
           RightWords=0;
        }

        
    }

    void EndGame()
    {
        RightWords=0;
        LevelIsWon=false;
        GameIsOver=true;
        GameOverUI.SetActive(true);
    }

    void LevelWon()
    {
        GameIsOver=true;
        RightWords=0;
        LevelIsWon=true;
        LevelWonUI.SetActive(true);
    }
}
