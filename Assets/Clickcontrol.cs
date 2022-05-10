using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickcontrol : MonoBehaviour
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
        gmScript.currentWord+=GetComponent<TextMesh>().text;
        gmScript.letterNum ++;
        gmScript.selectLetter[gmScript.letterNum]=GetComponent<TextMesh>().text;
        Debug.Log(gmScript.currentWord);
        
    }
}
