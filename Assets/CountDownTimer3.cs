using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer3 : MonoBehaviour
{
    public static float CurrentTime;
    public static float StartingTime=30f;
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
        if(gmlvl3.RightWords!=8 && !gmlvl3.LevelIsWon)
            CountDownText.text=CurrentTime.ToString("0");
        
    }
}
