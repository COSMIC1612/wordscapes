using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
   
    void Update()
    {
        if(gmScript.GameIsOver)
            this.enabled=false;
            return;  
    }
}
