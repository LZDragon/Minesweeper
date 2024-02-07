//////////////////////////////////////////////
//Assignment/Lab/Project: Minesweeper
//Name: Eliza Majernik
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 01/30/2024
/////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuInteraction : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button howToButton;
    [SerializeField] private Button closeButton;
    [SerializeField] private Button quitButton;

    [SerializeField] private GameObject howToPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        howToButton.onClick.AddListener(OpenHowTo);
        closeButton.onClick.AddListener(CloseHowTo);
        quitButton.onClick.AddListener(Quit);
        
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void OpenHowTo()
    {
        howToPanel.SetActive(true);
    }

    void CloseHowTo()
    {
        howToPanel.SetActive(false);
    }
    
    void Quit()
    {
        Application.Quit();
    }
}
