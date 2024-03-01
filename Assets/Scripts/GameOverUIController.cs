using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button retryButton;
    public Button mainMenuButton;

    private void Start()
    {
        retryButton.onClick.AddListener(RetryGame);
        mainMenuButton.onClick.AddListener(MainMenu);
    }
    
    public void RetryGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
