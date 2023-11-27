using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnakeHead : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private float moveSpeed = 3f;

    [SerializeField]
    private Transform snakeMovesTo;
    [SerializeField]
    private int bodyIndex = 0;

    private List<Transform> bodyParts = new List<Transform>();

    void Start()
    {
        snakeMovesTo.parent = null;
        snakeMovesTo.name = "asdeasdfa";
        snakeMovesTo.position = gameObject.transform.position;
        print("Spawn pos: " + snakeMovesTo.position);

        playerMovement = FindObjectOfType<PlayerMovement>();

    }

    //called from PlayerMovement when key is pressed
    public void MoveSnakeBody()
    {
        //gets the old player position
        snakeMovesTo.transform.position = playerMovement.oldPlayerPosition;
        print("What snake moves too" + snakeMovesTo.transform.position);
        
        //moves to it
        transform.position = Vector3.MoveTowards(transform.position, snakeMovesTo.position, moveSpeed * Time.deltaTime);
    }

    void Update()
    {
        //test?
        snakeMovesTo.transform.position = playerMovement.oldPlayerPosition;

        //test?
        snakeMovesTo.transform.position = new Vector3(playerMovement.oldPlayerPosition.x, playerMovement.oldPlayerPosition.y, playerMovement.oldPlayerPosition.z);

        transform.position = Vector3.MoveTowards(transform.position, snakeMovesTo.position, moveSpeed * Time.deltaTime);

    }
}

