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
using UnityEngine.Serialization;
using UnityEngine.UI;


public class Minesweeper : MonoBehaviour
{
    [SerializeField] private GameObject gridUIContainer;
    [SerializeField] private GameObject gridCellPrefab;
    private GameObject[,] gridCells = new GameObject[5, 5];
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int row = 0; row < gridCells.GetLength(0); row++)
        {
            for (int column = 0; column < gridCells.GetLength(1); column++)
            {
                gridCells[row, column] =
                    Instantiate(gridCellPrefab, new Vector3((row*50)+50, (column*50)+50), Quaternion.identity, gridUIContainer.transform);
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
