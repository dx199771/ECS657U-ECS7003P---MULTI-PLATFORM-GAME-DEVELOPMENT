using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider audioSlider;

    void Update()
    {
        float audioLevel = audioSlider.value;
        audioMixer.SetFloat("Master", audioLevel); //Update the volume value with the audio slider's value
        Debug.Log(audioLevel);
    }
}
