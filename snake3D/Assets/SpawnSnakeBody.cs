using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnakeBody : MonoBehaviour
{
    public static int amountOfBodiesSpawned;
    private PlayerMovement playerMovement;
    private int snakeSpawnCounterPosition = 0;

    [SerializeField]
    private GameObject snakeBody;

    public static List<GameObject> snakeBodies = new List<GameObject>();

    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    public void SpawnSnakeBodyPart()
    {
        //print("SpawnSnakeBodyTransform: " + playerMovement.oldPlayerPositions[amountOfBodiesSpawned]);
        //print("amountOfBodiesSpawned: " + amountOfBodiesSpawned);

        //Vector3 snakeBodyPosition = playerMovement.oldPlayerPosition;
        //going to need to change [0].
        Instantiate(snakeBody, playerMovement.oldPlayerPositions[snakeSpawnCounterPosition], Quaternion.identity);
        snakeBodies.Add(snakeBody);

        snakeSpawnCounterPosition += 1;
        amountOfBodiesSpawned += 1;
    }
}
