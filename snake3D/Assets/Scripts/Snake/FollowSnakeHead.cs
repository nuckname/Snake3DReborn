using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnakeHead : MonoBehaviour
{
    //replace FollowSnakeBody so that its the only script used.
    
    private PlayerMovement playerMovement;

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


    void Start()
    {
        snakeMovesTo.parent = null;
        snakeMovesTo.name = "asdeasdfa";
        snakeMovesTo.position = gameObject.transform.position;
        print("Spawn pos: " + snakeMovesTo.position);

        playerMovement = FindObjectOfType<PlayerMovement>();

        MoveSnakeBody();

    }

    public void MoveSnakeBody()
    {
        //gets the old player position
        //snakeMovesTo.transform.position = playerMovement.oldPlayerPosition;
        print("snakeMovesTo.transform.position: " + snakeMovesTo.transform.position);
        snakeMovesTo.transform.position = playerMovement.oldPlayerPositions[counter];
        counter += 1;


        //we want to move the pointer not the transform.
        SpawnSnakeBody.snakeBodies[counter].transform.position = playerMovement.oldPlayerPositions[counter];
        Vector3 test = snakeMovesTo.transform.position;
       // SpawnSnakeBody.snakeBodies[counter].GetComponentInParent<SnakeBody>

        //print("MoveSnakeBody()");

        /*
        snakeMovesTo.transform.position = getObjectPosition.GetPlayerPositionFunction(gameObject);

        print("What snake moves too" + snakeMovesTo.transform.position);
        
        //moves to it
    */
        transform.position = Vector3.MoveTowards(transform.position, snakeMovesTo.position, moveSpeed * Time.deltaTime);
    }

    void Update()
    {
        //test?
        //snakeMovesTo.transform.position = getObjectPosition.GetPlayerPositionFunction(gameObject);

        //test?
        //snakeMovesTo.transform.position = new Vector3(playerMovement.oldPlayerPosition.x, playerMovement.oldPlayerPosition.y, playerMovement.oldPlayerPosition.z);

        snakeMovesTo.transform.position = Vector3.MoveTowards(transform.position, snakeMovesTo.position, moveSpeed * Time.deltaTime);

    }
}

