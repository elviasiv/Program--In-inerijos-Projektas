using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour {


    public AudioClip MusicClip;
    public AudioSource EffectSource;

    void Start () {
        EffectSource.clip = MusicClip;
        EffectSource.Play();
        EffectSource.volume = PlayerPrefs.GetFloat("SliderVolumeLevel", EffectSource.volume);
    }
	
}
