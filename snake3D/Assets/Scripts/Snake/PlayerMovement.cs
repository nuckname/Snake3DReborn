using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    public Transform playerPoint;
    public Vector3 direction;

    [SerializeField]
    private GetObjectPosition getObjectPosition;

    [SerializeField]
    private HistoryOfPlayerMovement historyOfPlayerMovement;

    [SerializeField]
    private FollowSnakeHead followSnakeHead;

    GameManager gameManager;

    private void Start()
    {
        playerPoint.parent = null;
        moveSpeed = 3f;

        //will this get the correct Object if there are two or more snakeson the board 
        //followSnakeHead = FindObjectOfType<FollowSnakeHead>();

    }

    //called after every key press.
    public void MovePlayer(Vector3 movementDirection, Vector3 playerInputDirection)
    {
        direction = playerInputDirection;
        playerPoint.position += movementDirection;

        historyOfPlayerMovement.AddMovementWithCurrentListValue();
    }

    private void UpdateFollowSnakePosition()
    {
        //this is bad but idk where to put it. it was in Start() however it makes it null.
        followSnakeHead = FindObjectOfType<FollowSnakeHead>();

        //UpdateFollowSnakePosition
        followSnakeHead.UpdateSnakeBodies();
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPoint.position, moveSpeed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, playerPoint.position) <= 0.05f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                MovePlayer(new Vector3(0, 0, moveSpeed), Vector3.forward);
                UpdateFollowSnakePosition();
            }

            if (Input.GetKey(KeyCode.A))
            {
                MovePlayer(new Vector3(-moveSpeed, 0, 0), Vector3.left);
                UpdateFollowSnakePosition();
            }

            if (Input.GetKey(KeyCode.S))
            {
                MovePlayer(new Vector3(0, 0, -moveSpeed), Vector3.back);
                UpdateFollowSnakePosition();
            }

            if (Input.GetKey(KeyCode.D))
            {
                MovePlayer(new Vector3(moveSpeed, 0, 0), Vector3.right);
                UpdateFollowSnakePosition();
            }

            if (Input.GetKey(KeyCode.Space))
            {
                MovePlayer(new Vector3(0, moveSpeed, 0), Vector3.up);
                UpdateFollowSnakePosition();
                // Change block color
            }

            if (Input.GetKey(KeyCode.LeftControl))
            {
                MovePlayer(new Vector3(0, -moveSpeed, 0), Vector3.down);
                UpdateFollowSnakePosition();
                // Change block color
            }

        }
    }
}
