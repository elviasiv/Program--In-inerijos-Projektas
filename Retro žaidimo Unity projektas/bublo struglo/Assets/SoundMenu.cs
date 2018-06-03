using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMenu : MonoBehaviour {

    public AudioMixer audioMixer;

	public void SetVolume(float volume)
    {

        audioMixer.SetFloat("volume", volume);

    }
    float vol = 0.0f; // AudioSource.volume will have a value 0.0f to 1.0f
    void SaveSliderValue()
    {
        PlayerPrefs.SetFloat("SliderVolumeLevel", vol);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

}
