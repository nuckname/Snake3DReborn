using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    //currently not using the currentGridValues;
    //no gaps = gridSpacing and gridCell scale values should be the same.
    public int gridX = 5;
    public int gridY = 5;
    public int gridZ = 5;
    public float girdSpacing = 3.0f;
    [SerializeField]
    private  GameObject cubePrefab;

    private Vector3[,,] currentGridValues;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        currentGridValues = new Vector3[gridZ, gridY, gridX];

        for (int x = 0; x < gridZ; x++)
        {
            for(int y = 0; y < gridY; y++)
            {
                for (int z = 0; z < gridX; z++)
                {
                    Vector3 spawnPosition = new Vector3(x * girdSpacing, y * girdSpacing, z * girdSpacing);
                    currentGridValues[x, y, z] = spawnPosition;
                    //print(currentGridValues[x, y, z]);

                    //this is just for debugging remove visual later.
                    GameObject cube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

                    cube.name = $"grid: {x}, {y}, {z}";
                    cube.transform.parent = this.transform;


                }
            }
        }
    }


}
