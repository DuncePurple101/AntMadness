using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource AudioSource;
    public Slider volumeSlider;


    //Value frp, the slider, and it convert to volume level
    public float MusicVolume = .1f;


    private void Start()
    {
        MusicVolume = .3f;
        AudioSource.Play();
        MusicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = MusicVolume;
        //volumeSlider.value = MusicVolume;
    }



    private void Update()
    {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("volume", MusicVolume);
    }


    public void updateVolume(float volume)
    {
        MusicVolume = volume;
    }


    public void MusicReset()
    {
        PlayerPrefs.DeleteKey("volume");
        AudioSource.volume = .1f;
        volumeSlider.value = .1f;

    }
}
