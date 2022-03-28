using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu_UI : MonoBehaviour
{
    public bool MainMenu = true;
    public GameObject Player;
    public void PlayGame()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        MainMenu = false;
        Player.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void Start()
    {
        Time.timeScale = 0f;
        Player.SetActive(false);
    }
}
