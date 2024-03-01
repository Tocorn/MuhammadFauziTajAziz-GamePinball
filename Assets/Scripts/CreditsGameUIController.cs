using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsGameUIController : MonoBehaviour
{
    public Button gobackButton;

    private void Start()
    {
        gobackButton.onClick.AddListener(goBack);
    }
    
    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}