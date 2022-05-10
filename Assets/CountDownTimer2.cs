using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer2 : MonoBehaviour
{
    public static float CurrentTime;
    public static float StartingTime=15f;
    public Text CountDownText;
    
    

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime=StartingTime;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -=1 * Time.deltaTime;
        

        if(CurrentTime<=0)
            CurrentTime=0;
        if(gmlvl2.RightWords!=4 && !gmlvl2.LevelIsWon)
            CountDownText.text=CurrentTime.ToString("0");
        
    }
}
