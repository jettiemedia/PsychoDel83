using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button newGameButton;
    public Button LoadButton;
    public Button exitGameButton;
    public GameObject loadGameMenu;
    public GameObject howToPlayMenu;
    public GameObject CrewMenu;
    public string newGameSceneName;

    //button audio variables
    public AudioSource buttonFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public void NewGame()
    {
         SceneManager.LoadScene(newGameSceneName);


    }

    public void OpenLoadGameMenu()
    {
        loadGameMenu.SetActive(true);
    }

    public void OpenHowToPlayMenu()
    {
        howToPlayMenu.SetActive(true);
    }

    public void OpenCrewMenu()
    {
       CrewMenu.SetActive(true);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

   public void doquit()
    {
        Debug.Log("Game is exiting");
        Application.Quit();
    }


    //audio call functions
    public void HoverSound()
    {
        buttonFx.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        buttonFx.PlayOneShot(clickFx);
    }
}