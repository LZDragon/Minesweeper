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
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GridCell : MonoBehaviour, IPointerClickHandler
{
    private bool isMine;
    private int nearbyMines;
    private Button gridButton;
    private Text buttonText;
    private bool flag;

    private void Awake()
    {
        nearbyMines = -1;
        isMine = false;
        flag = false;
        gridButton = GetComponentInParent<Button>();
        buttonText = gridButton.GetComponentInChildren<Text>();
        //gridButton.onClick.AddListener(HandleButtonClick);
    }

    public void SetIsMine(bool isMine)
    {
        this.isMine = isMine;
    }
    

    public void SetNearbyMines(int nearbyMines)
    {
        this.nearbyMines = nearbyMines;
    }
    
/// <summary>
/// Method <c>SetButtonText</c> Displays the amount of nearby mines on the button
/// </summary>
    void SetButtonText()
    {
        buttonText.text = nearbyMines.ToString();
    }
    
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            gridButton.interactable = false;
            gridButton.image.color = new Color(125, 92, 30);//brown
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
        //Flag functionality
        else
        {
            if (flag)
            {
                gridButton.image.color = Color.white;
                flag = false;
            }
            else
            {
                gridButton.image.color = Color.red;
                flag = true;
            }
            Debug.Log("right-clicked button");
            
        }

    }
    
}
