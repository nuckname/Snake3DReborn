using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPower : MonoBehaviour
{
    private GridGenerator gridGenerator;

    [SerializeField]
    private GameObject powerUp;



    private int spawnCoordinateWidth;
    private int spawnCoordinateHeight;
    private int spawnCoordinateLength;

    private Vector3 spawnCoorinates;

    // Start is called before the first frame update
    void Start()
    {
        gridGenerator = GetComponent<GridGenerator>();
        SpawningPower();
    }

    public void SpawningPower()
    {

        // So it always divisible by 3 for each dimension
        do
        {
            spawnCoordinateWidth = Random.Range(0, gridGenerator.gridZ * 3 - 3);
        } while (!(spawnCoordinateWidth % 3 == 0));

        do
        {
            spawnCoordinateHeight = Random.Range(0, gridGenerator.gridY * 3 - 3);
        } while (!(spawnCoordinateHeight % 3 == 0));

        do
        {
            spawnCoordinateLength = Random.Range(0, gridGenerator.gridX * 3 - 3);
        } while (!(spawnCoordinateLength % 3 == 0));


        spawnCoorinates = new Vector3(spawnCoordinateWidth, spawnCoordinateHeight, spawnCoordinateLength);
        print("Power Spawn Coorinates: " + spawnCoorinates);
        Instantiate(powerUp, spawnCoorinates, Quaternion.identity);
    }
}
