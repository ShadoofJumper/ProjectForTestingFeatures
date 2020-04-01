﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private TextMeshProUGUI smile;
    [SerializeField] private Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        smile.alpha = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // ------------- main menu
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void TurnSettings()
    {
        menuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    // ------------- settings

    public void BackToMenu()
    {
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void SliderChange()
    {
        smile.alpha = slider.value;
    }


}
