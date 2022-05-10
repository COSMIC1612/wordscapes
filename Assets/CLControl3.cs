using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CLControl3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnMouseDown()
    {
        gmlvl3.currentWord+=GetComponent<TextMesh>().text;
        gmlvl3.letterNum ++;
        gmlvl3.selectLetter[gmlvl3.letterNum]=GetComponent<TextMesh>().text;
        Debug.Log(gmlvl3.currentWord);
    }
}
