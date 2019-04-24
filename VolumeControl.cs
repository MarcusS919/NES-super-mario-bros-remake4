using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour {

    AudioSource audio;

    public Slider VolumeSlider;

    public Toggle MuteToggle;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        Volume();

    }

  

    public void Volume()
    {
        if (MuteToggle == false)
        {
            audio.volume = 0;
        }
        else
        {
            audio.volume = VolumeSlider.value;
        }
    }
}
