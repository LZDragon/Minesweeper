//////////////////////////////////////////////
//Assignment/Lab/Project: Minesweeper
//Name: Eliza Majernik
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 01/30/2024
/////////////////////////////////////////////using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinChecker : MonoBehaviour
{
    public static WinChecker instance;
    private int numberNonMineCells = 20;
    private int numberClickedCells;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddClicked()
    {
        numberClickedCells++;
        CheckWin();
    }

    void CheckWin()
    {
        if (numberClickedCells >= numberNonMineCells)
        {
            Debug.Log("Winner");
            SceneManager.LoadScene(3);
        }
    }

    public void SetNonMineCellAmount(int numberNonMineCells)
    {
        this.numberNonMineCells = numberNonMineCells;
    }
    
}
