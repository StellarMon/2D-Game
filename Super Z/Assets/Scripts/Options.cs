using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volumeMaster", volume);
    }

    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
}
