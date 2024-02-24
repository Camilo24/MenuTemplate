using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quality : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown qualityDropdown;
    [SerializeField] private static int qualityValue;

    void Start()
    {
        qualityValue = PlayerPrefs.GetInt("qualityNumber", 3);
        qualityDropdown.value = qualityValue;
        AdjustQuality();
    }

    public void AdjustQuality()
    {
        QualitySettings.SetQualityLevel(qualityDropdown.value);
        PlayerPrefs.SetInt("qualityNumber", qualityDropdown.value);
        qualityValue = qualityDropdown.value;
    }
}