using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnakeBody : MonoBehaviour
{
    public static int amountOfBodiesSpawned;
    
    [SerializeField]
    private HistoryOfPlayerMovement historyOfPlayerMovement;
    
    private int snakeSpawnCounterPosition = 0;

    [SerializeField]
    private GameObject snakeBody;

    public List<GameObject> snakeParentBodies = new List<GameObject>();
    private void Start()
    {
        historyOfPlayerMovement = FindObjectOfType<HistoryOfPlayerMovement>();
    }

    //Called On SnakeCollision
    public void SpawnSnakeBodyPart()
    {
        GameObject newSnakeBody = Instantiate(snakeBody, historyOfPlayerMovement.oldPlayerPositions[snakeSpawnCounterPosition], Quaternion.identity);
        //loop through this in FollowSnakeHead.cs 
        snakeParentBodies.Add(newSnakeBody);

        snakeSpawnCounterPosition += 1;
        amountOfBodiesSpawned += 1;
    }
}
