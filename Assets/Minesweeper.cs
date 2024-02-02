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
    private const int gridSize = 5;
    private const int numOfMines = 5;
    [SerializeField] private GameObject gridUIContainer;
    [SerializeField] private GameObject gridCellPrefab;
    private GameObject[,] gridCells = new GameObject[gridSize, gridSize];
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        List<Vector2> generatedMineCoordinates = GenerateMines();
        Vector2 currentCoordinate;
        for (int row = 0; row < gridCells.GetLength(0); row++)
        {
            for (int column = 0; column < gridCells.GetLength(1); column++)
            {
                currentCoordinate = new Vector2(row, column);
                gridCells[row, column] =
                    Instantiate(gridCellPrefab, new Vector3((row*50)+50, (column*50)+50), Quaternion.identity, gridUIContainer.transform);
                if (generatedMineCoordinates.Contains(currentCoordinate))
                {
                    gridCells[row,column].GetComponent<GridCell>().SetIsMine(true);
                    Debug.Log($"[{row},{column}]: Has mine");
                }
                else
                {
                    gridCells[row,column].GetComponent<GridCell>().SetNearbyMines(CountNearbyMines(currentCoordinate, generatedMineCoordinates));
                }

            }
        }
    }

    List<Vector2> GenerateMines()
    {
        List<Vector2> mineCoordinates = new List<Vector2>();
        int mine = 0;
        Vector2 coordinate;
        while (mine <= numOfMines)
        {
            coordinate = new Vector2(Random.Range(0, gridSize), Random.Range(0,gridSize));
            if (mineCoordinates.Contains(coordinate))
            {
                continue;
            }

            mineCoordinates.Add(coordinate);
            mine++;
        }

        return mineCoordinates;
    }
    

    void CheckIfBomb()
    {
        
    }

    int CountNearbyMines(Vector2 coordinates, List<Vector2> mineList)
    {
        int count = 0;
        //UpperLeft
        if (coordinates.x != 0 && coordinates.y < gridSize &&
            mineList.Contains(new Vector2(coordinates.x - 1, coordinates.y + 1)))
        {
            count++;
        }
        //Upper
        if (coordinates.y <= gridSize - 1 && mineList.Contains(new Vector2(coordinates.x, coordinates.y + 1)))
        {
            count++;
        }
        //UpperRight
        if (coordinates.x < gridSize && coordinates.y < gridSize &&
            mineList.Contains(new Vector2(coordinates.x + 1, coordinates.y + 1)))
        {
            count++;
        }
        //Left
        if (coordinates.x != 0 &&
            mineList.Contains(new Vector2(coordinates.x - 1, coordinates.y)))
        {
            count++;
        }
        //Right
        if (coordinates.x < gridSize &&
            mineList.Contains(new Vector2(coordinates.x + 1, coordinates.y)))
        {
            count++;
        }
        //LowerLeft
        if (coordinates.x != 0 && coordinates.y != 0 &&
            mineList.Contains(new Vector2(coordinates.x - 1, coordinates.y - 1)))
        {
            count++;
        }
        //Lower
        if (coordinates.y != 0 &&
            mineList.Contains(new Vector2(coordinates.x, coordinates.y - 1)))
        {
            count++;
        }
        //LowerRight
        if (coordinates.x < gridSize && coordinates.y != 0 &&
            mineList.Contains(new Vector2(coordinates.x + 1, coordinates.y - 1)))
        {
            count++;
        }
        Debug.Log($"[{coordinates.x},{coordinates.y}]: Has {count} mines around it");
        return count;
    }

}
