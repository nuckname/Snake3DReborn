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

    //should use at some point. STATIC BAD
    public static List<Transform> snakeParentBodies = new List<Transform>();
    private void Start()
    {
        historyOfPlayerMovement = FindObjectOfType<HistoryOfPlayerMovement>();
    }

    //Called On SnakeCollision
    public void SpawnSnakeBodyPart()
    {
        Instantiate(snakeBody, historyOfPlayerMovement.oldPlayerPositions[snakeSpawnCounterPosition], Quaternion.identity);
        snakeParentBodies.Add(snakeBody.transform.parent);

        snakeSpawnCounterPosition += 1;
        amountOfBodiesSpawned += 1;
    }
}
