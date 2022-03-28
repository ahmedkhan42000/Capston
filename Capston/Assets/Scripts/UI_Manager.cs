using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public bool MainMenu = true;
    public GameObject Player;

    public GameObject PauseMenu_UI;
    public GameObject MainMenu_UI;
    public Shoot_Practice shoot_P;
    public HealthManager healthManager;

    public TextMeshProUGUI ScoreText;
    public int Score = 0;

    private void Start()
    {
        Time.timeScale = 0f;
        Player.SetActive(false);

        //shoot_P =GameObject.Find("Player_Character").GetComponent<Shoot_Practice>();
        shoot_P.updateScore_OnVirusHit_DL += updateScore_OnVirusHit;
        healthManager.updateScore_OnCivHit_DL += updateScore_OnCivHit;
        ScoreText.text = "Score : " + Score;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void updateScore_OnVirusHit()
    {
        Score += 10;
        ScoreText.text = "Score : " + Score;
        Debug.Log("VIRUS DELEGATE WORKING");
    }
    public void updateScore_OnCivHit()
    {
        Score += 20;
        ScoreText.text = "Score : " + Score;
        Debug.Log("Civ DELEGATE WORKING");
    }
    public void Pause()
    {
        PauseMenu_UI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

   public  void Resume()
    {
        PauseMenu_UI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void LoadMenu()
    {
        Debug.Log("LOAD BUTTON WORKING");
        MainMenu_UI.SetActive(true);
        PauseMenu_UI.SetActive(false);
    }
    public void PlayGame()
    {
        //gameObject.SetActive(false);
        MainMenu_UI.SetActive(false);
        Time.timeScale = 1f;
        MainMenu = false;
        Player.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit BUTTON WORKING");
        Application.Quit();
    }
}
