using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public OptionsController panelOptions;
    void Start()
    {
        panelOptions = GameObject.FindWithTag("Options").GetComponent<OptionsController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (SceneManager.GetActiveScene().buildIndex == 0))
        {
            ShowOptions();
        }
    }

    public void ShowOptions()
    {
        panelOptions.optionsScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}