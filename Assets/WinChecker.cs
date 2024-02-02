using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
    }
    
}
