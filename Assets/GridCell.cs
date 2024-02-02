//////////////////////////////////////////////
//Assignment/Lab/Project: Minesweeper
//Name: Eliza Majernik
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 01/30/2024
/////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GridCell : MonoBehaviour
{
    private bool isMine;
    private int nearbyMines;
    private Button gridButton;
    private Text buttonText;

    private void Awake()
    {
        nearbyMines = -1;
        isMine = false;
        gridButton = GetComponentInParent<Button>();
        buttonText = gridButton.GetComponentInChildren<Text>();
        gridButton.onClick.AddListener(HandleButtonClick);
    }

    public void SetIsMine(bool isMine)
    {
        this.isMine = isMine;
    }
    

    public void SetNearbyMines(int nearbyMines)
    {
        this.nearbyMines = nearbyMines;
    }

    void SetButtonText()
    {
        buttonText.text = nearbyMines.ToString();
    }

    void HandleButtonClick()
    {

        gridButton.interactable = false;
        if (isMine)
        {
            Debug.Log("Boom");
            SceneManager.LoadScene("Scenes/GameOver");
        }
        else
        {
            SetButtonText();
            WinChecker.instance.AddClicked();
        }

    }
    
}
