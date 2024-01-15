using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnakeHead : MonoBehaviour
{
    [SerializeField]
    private HistoryOfPlayerMovement historyOfPlayerMovement;

    [SerializeField]
    private SpawnSnakeBody spawnSnakeBody; 

    private void Start()
    {
        //historyOfPlayerMovement = FindObjectOfType<HistoryOfPlayerMovement>();
    }

    //called after every key press
    public void UpdateSnakeBodies()
    {
        //print(spawnSnakeBody.snakeParentBodies[1]);
    }

}

