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
        historyOfPlayerMovement = FindObjectOfType<HistoryOfPlayerMovement>();
        spawnSnakeBody = FindObjectOfType<SpawnSnakeBody>();
    }

    //Updated after each key pressed.
    public void UpdateSnakeBodies()
    {
        //I do what not sure how to use.
        print("a" + spawnSnakeBody.snakeParentBodies[0]);

        print("b" + historyOfPlayerMovement.oldPlayerPositions[0]);

        print("c" + historyOfPlayerMovement.oldPlayerPositions.Count);

        for (int i = historyOfPlayerMovement.oldPlayerPositions.Count - 1; i > 0; i--)
        {
            print("i is equal to: " + i + " minus 1");
            //we want to move the snake pointer. and then Update() and this gameobjets moves towards it.
            spawnSnakeBody.snakeParentBodies[0].gameObject.transform.position = historyOfPlayerMovement.oldPlayerPositions[i - 1];
        }

    }

}

