using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnakeHead : MonoBehaviour
{
    //replace FollowSnakeBody so that its the only script used.

    private float moveSpeed = 3f;

    [SerializeField]
    private Vector3 testPlayerTransformOldPlayerPosition;

    [SerializeField]
    private GetObjectPosition getObjectPosition;

    [SerializeField]
    private Transform snakeMovesTo;
    [SerializeField]
    private int bodyIndex = 0;

    private int counter = 0;

    [SerializeField]
    private PlayerMovement playerMovement;

    

    void Start()
    {
        snakeMovesTo.parent = null;
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    public void MoveSnakeBody()
    {
        /*
        if (counter < playerMovement.oldPlayerPositions.Count)
        {
            snakeMovesTo.position = playerMovement.oldPlayerPositions[counter];
            counter++;
        }
        */
    }

    private void GettingOldPlayerPositions()
    {
        //List<Vector3> hello = playerMovement.PlayerHistoryOfMovement();
    }

}

