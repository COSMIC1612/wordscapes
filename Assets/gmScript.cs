using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gmScript : MonoBehaviour
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
    public Transform bottomL1Obj;
    public Transform bottomL2Obj;
    public Transform bottomL3Obj;
    public Transform bottomL4Obj;
    public static List<string> availLetter1 = new List<string> () {"H"};
    public static List<string> availLetter2 = new List<string> () {"T"};
    public static List<string> availLetter3 = new List<string> () {"E"};
    public static List<string> availLetter4 = new List<string> () {"A"};
    public KeyCode RMB;
    public int wordLen;
    public static string word3L="EAT";
    public static string word4L="HEAT";
    public static List<string> selectLetter = new List<string> () {"","","","","","","",""};
    public static int letterNum=0;




    // Start is called before the first frame update
    void Start()
    {
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
                letter1.GetComponent<TextMesh>().text=selectLetter[1];
                letter2.GetComponent<TextMesh>().text=selectLetter[2];
                letter3.GetComponent<TextMesh>().text=selectLetter[3]; 
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
                letter4.GetComponent<TextMesh>().text=selectLetter[1];
                letter5.GetComponent<TextMesh>().text=selectLetter[2];
                letter6.GetComponent<TextMesh>().text=selectLetter[3];
                letter7.GetComponent<TextMesh>().text=selectLetter[4];
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

        

    }
}
