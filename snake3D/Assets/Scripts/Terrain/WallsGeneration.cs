using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsGeneration : MonoBehaviour
{
    private GridGenerator gridGenerator;

    [SerializeField]
    private GameObject wallsPrefab;
    [SerializeField]
    private GameObject floorPrefab;

    private void Start()
    {
        gridGenerator = GetComponent<GridGenerator>();
        //GenerateWalls();
        //GenerateFloor();
    }

    private void GenerateWalls()
    {
        // Spawn walls on the X-axis
        SpawnWallAt(new Vector3(-gridGenerator.girdSpacing / 2f, 0, gridGenerator.gridZ * gridGenerator.girdSpacing / 2f), true); // Left
        SpawnWallAt(new Vector3(gridGenerator.gridX * gridGenerator.girdSpacing + gridGenerator.girdSpacing / 2f, 0, gridGenerator.gridZ * gridGenerator.girdSpacing / 2f), true); // Right

        // Spawn walls on the Z-axis
        SpawnWallAt(new Vector3(gridGenerator.gridX * gridGenerator.girdSpacing / 2f, 0, -gridGenerator.girdSpacing / 2f), false); // Bottom
        SpawnWallAt(new Vector3(gridGenerator.gridX * gridGenerator.girdSpacing / 2f, 0, gridGenerator.gridZ * gridGenerator.girdSpacing + gridGenerator.girdSpacing / 2f), false); // Top
    }

    private void SpawnWallAt(Vector3 position, bool isVertical)
    {
        GameObject wall = Instantiate(wallsPrefab, position, Quaternion.identity);
        wall.name = isVertical ? "VerticalWall" : "HorizontalWall";

        float wallHeight = gridGenerator.gridY * gridGenerator.girdSpacing;
        wall.transform.localScale = isVertical ? new Vector3(gridGenerator.girdSpacing, wallHeight, gridGenerator.gridZ * gridGenerator.girdSpacing) : new Vector3(gridGenerator.gridX * gridGenerator.girdSpacing, wallHeight, gridGenerator.girdSpacing);

        // Set the wall as a child of the WallsGeneration GameObject
        wall.transform.parent = this.transform;
    }

    private void GenerateFloor()
    {
        float floorWidth = gridGenerator.gridX * gridGenerator.girdSpacing;
        float floorLength = gridGenerator.gridZ * gridGenerator.girdSpacing;

        Vector3 floorPosition = new Vector3(floorWidth / 2, -0.5f, floorLength / 2); // Adjust the Y position as needed
        GameObject floor = Instantiate(floorPrefab, floorPosition, Quaternion.identity);
        floor.transform.localScale = new Vector3(floorWidth, 1f, floorLength);
        floor.name = "Floor";

        // Set the floor as a child of the WallsGeneration GameObject
        floor.transform.parent = this.transform;
    }
}
