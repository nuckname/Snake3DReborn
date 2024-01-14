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
    private void Start()
    {
        playerPoint.parent = null;
        moveSpeed = 3f;
    }

    //called after every key press.
    void MovePlayer(Vector3 movementDirection, Vector3 playerInputDirection)
    {
        //I dont think this does anything
        direction = playerInputDirection;
        //I dont think this does anything
        playerPoint.position += movementDirection;

        historyOfPlayerMovement.AddMovementWithCurrentListValue();

    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPoint.position, moveSpeed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, playerPoint.position) <= 0.05f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                MovePlayer(new Vector3(0, 0, moveSpeed), Vector3.forward); 
            }

            if (Input.GetKey(KeyCode.A))
            {
                MovePlayer(new Vector3(-moveSpeed, 0, 0), Vector3.left);
            }

            if (Input.GetKey(KeyCode.S))
            {
                MovePlayer(new Vector3(0, 0, -moveSpeed), Vector3.back);
            }

            if (Input.GetKey(KeyCode.D))
            {
                MovePlayer(new Vector3(moveSpeed, 0, 0), Vector3.right);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                MovePlayer(new Vector3(0, moveSpeed, 0), Vector3.up);
                // Change block color
            }

            if (Input.GetKey(KeyCode.LeftControl))
            {
                MovePlayer(new Vector3(0, -moveSpeed, 0), Vector3.down);
                // Change block color
            }

        }
    }
}
