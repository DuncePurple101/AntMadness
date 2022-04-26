using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    //public void SetVolume(float volume)
    //{
    //    Debug.Log(volume);
    //    audioMixer.SetFloat("volume", volume);
    //}
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    //public void Mute(bool isMuted)
    //{
    //    if (isMuted)
    //    {
    //        AudioListener.volume = 0f;
    //    }
    //    else
    //    {
    //        AudioListener.volume = 0.1f;
    //    }
    //    AudioListener.volume = 0f;
    //}
}

