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
using UnityEngine.UI;

public class GridCell : MonoBehaviour
{
    [SerializeField] private Button gridCellPrefab;
    private bool isMine;
    private int nearbyMines;
    private Button gridButton;

    private void Awake()
    {
        nearbyMines = -1;
        isMine = false;
    }
    
    public bool GetIsMine()
    {
        return isMine;
    }

    public int GetNearbyMines()
    {
        return nearbyMines;
    }

    public void SetNearbyMines(int _nearbyMines)
    {
        nearbyMines = _nearbyMines;
    }
    
    
}
