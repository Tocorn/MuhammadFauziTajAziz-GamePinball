using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button creditsButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        creditsButton.onClick.AddListener(CreditsGame);
        exitButton.onClick.AddListener(ExitGame);
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void CreditsGame()
    {
        SceneManager.LoadScene("CreditsGame");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}