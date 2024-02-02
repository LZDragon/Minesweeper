//////////////////////////////////////////////
//Assignment/Lab/Project: Minesweeper
//Name: Eliza Majernik
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 01/30/2024
/////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Minesweeper : MonoBehaviour
{
    [SerializeField] private GameObject grid;
    private GridCell[,] gridCells = new GridCell[5, 5];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void GenerateGrid()
    {
        for (int row = 0; row < gridCells.GetLength(0); row++)
        {
            for (int column = 0; column < gridCells.GetLength(1); column++)
            {

            }
        }
    }
    

    void CheckIfBomb()
    {
        
    }

    void CountNearbyBombs()
    {
        
    }

}
