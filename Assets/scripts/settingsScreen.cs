using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;


public class settingsScreen : MonoBehaviour
{
    public Toggle fullscreenTog;
    public AudioMixer theMixer;
    public TMP_Text masterlabel, musiclabel, sfxlabel;
    public Slider masterSLider, musicSlider, sfxSlider;
    void Start()
    {
        fullscreenTog.isOn =  Screen.fullScreen;



        float vol = 0f;
        theMixer.GetFloat("mastervol", out vol);
        masterSLider.value = vol;
        theMixer.GetFloat("musicvol", out vol);
        musicSlider.value = vol;
        theMixer.GetFloat("sfxvol", out vol);
        sfxSlider.value = vol;

        masterlabel.text = Mathf.RoundToInt(masterSLider.value
            + 80).ToString();

        musiclabel.text = Mathf.RoundToInt(musicSlider.value
            + 80).ToString();

        sfxlabel.text = Mathf.RoundToInt(sfxSlider.value
           + 80).ToString();


    }




    public void SetMasterVol()
    {
        masterlabel.text = Mathf .RoundToInt(masterSLider.value
            + 80).ToString(); 

        theMixer.SetFloat("mastervol" , masterSLider.value);

        PlayerPrefs.SetFloat("mastervol", masterSLider.value);


    }
    public void SetMusicVol()
    {
        musiclabel.text = Mathf.RoundToInt(musicSlider.value
            + 80).ToString();

        theMixer.SetFloat("musicvol", musicSlider.value);

        PlayerPrefs.SetFloat("musicvol", musicSlider.value);

    }
    public void SetSoundEffectsVol()
    {
        sfxlabel.text = Mathf.RoundToInt(sfxSlider.value
            + 80).ToString();

        theMixer.SetFloat("sfxvol", sfxSlider.value);

        PlayerPrefs.SetFloat("sfxvol", sfxSlider.value);

    }

    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreenTog.isOn;

    }






}
 