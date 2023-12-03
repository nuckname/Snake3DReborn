using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnakeBody : MonoBehaviour
{
    public static int amountOfBodiesSpawned;
    
    [SerializeField]
    private PlayerMovement playerMovement;
    
    private int snakeSpawnCounterPosition = 0;

    [SerializeField]
    private GameObject snakeBody;

    public static List<Transform> snakeParentBodies = new List<Transform>();
    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    //Called On SnakeCollision
    public void SpawnSnakeBodyPart()
    {
        //print("SpawnSnakeBodyTransform: " + playerMovement.oldPlayerPositions[amountOfBodiesSpawned]);
        //print("amountOfBodiesSpawned: " + amountOfBodiesSpawned);

        //Vector3 snakeBodyPosition = playerMovement.oldPlayerPosition;
        //going to need to change [0].
        Instantiate(snakeBody, playerMovement.oldPlayerPositions[snakeSpawnCounterPosition], Quaternion.identity);
        print("snakeBody.transform.parent: " + snakeBody.transform.parent);
        snakeParentBodies.Add(snakeBody.transform.parent);

        snakeSpawnCounterPosition += 1;
        amountOfBodiesSpawned += 1;
    }
}
