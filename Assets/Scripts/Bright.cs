using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bright : MonoBehaviour
{
    [SerializeField] private Slider sliderBright;
    [SerializeField] private float sliderBrightValue;
    [SerializeField] private Image panelBright;
    void Start()
    {
        sliderBright.value = PlayerPrefs.GetFloat("bright", 0.5f);
        panelBright.color = new Color(panelBright.color.r, panelBright.color.g, panelBright.color.b, sliderBright.value);
    }

    public void ChangeSlider(float value)
    {
        sliderBrightValue = value;
        PlayerPrefs.SetFloat("bright", sliderBrightValue);
        panelBright.color = new Color(panelBright.color.r, panelBright.color.g, panelBright.color.b, sliderBright.value);
    }
}