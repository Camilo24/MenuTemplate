using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private Slider sliderVolume;
    [SerializeField] private float sliderVolumeValue;

    void Start()
    {
        sliderVolume.value = PlayerPrefs.GetFloat("volumeAudio", 0.5f);
        AudioListener.volume = sliderVolume.value;
    }

    public void ChangeSlider(float value)
    {
        sliderVolumeValue = value;
        PlayerPrefs.SetFloat("volumeAudio", sliderVolumeValue);
        AudioListener.volume = sliderVolume.value;
    }
}