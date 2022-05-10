using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLControl : MonoBehaviour
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
        gmlvl2.currentWord+=GetComponent<TextMesh>().text;
        gmlvl2.letterNum ++;
        gmlvl2.selectLetter[gmlvl2.letterNum]=GetComponent<TextMesh>().text;
        Debug.Log(gmlvl2.currentWord);
    }
}
