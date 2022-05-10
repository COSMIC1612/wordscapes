using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audiomanager : MonoBehaviour
{
    public AudioMixer theMixer;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("mastervol"))
        {
            theMixer.SetFloat("mastervol", PlayerPrefs.GetFloat("mastervol"));
        }
        if (PlayerPrefs.HasKey("musicvol"))
        {
            theMixer.SetFloat("musicvol", PlayerPrefs.GetFloat("musicvol"));
        }
        if (PlayerPrefs.HasKey("sfxvol"))
        {
            theMixer.SetFloat("sfxvol", PlayerPrefs.GetFloat("sfxvol"));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
