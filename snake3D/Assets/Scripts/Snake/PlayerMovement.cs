using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    //player cannot stop moving.

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float actionCooldownMinimumSeconds = 1.0f;
    [SerializeField]
    private float actionCooldownMaximumSeconds = 2.5f;
    [SerializeField]
    private float actionCooldownMaximumResetSeconds;

    public Transform playerPoint;

    public Vector3 direction;

    [SerializeField]
    private GetPlayerPosition getPlayerPosition;

    [SerializeField]
    private FollowSnakeHead followSnakeHead;


    //make static?
    public Vector3 oldPlayerPosition = new Vector3(0,0,0);

    //players start 0,0,0
    //then I just manual add it??
    public int[,,] GetPlayerPositionInGrid;
    private void Start()
    {
        followSnakeHead = FindObjectOfType<FollowSnakeHead>();

        actionCooldownMaximumResetSeconds = actionCooldownMaximumSeconds + 0.5f;

        playerPoint.parent = null;

        moveSpeed = 3f;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPoint.position, moveSpeed * Time.deltaTime);

        //can only move when reaches playerPoint
        if (Vector3.Distance(transform.position, playerPoint.position) <= 0.05f)
        {
            if (Input.GetKey(KeyCode.W))
            {


                direction = Vector3.forward;

                playerPoint.position += new Vector3(0, 0, moveSpeed);

                oldPlayerPosition = getPlayerPosition.GetPlayerPositionFunction(gameObject);
                //print("oldPlayerPosition value: " + oldPlayerPosition);


                //what happens when there are two objects?
                //just use tags with gameobjectS

                /*
                if(followSnakeHead != null)
                {
                    followSnakeHead.MoveSnakeBody();
                }
                */
            }

            if (Input.GetKey(KeyCode.A))
            {
                direction = Vector3.left;

                playerPoint.position += new Vector3(-moveSpeed, 0, 0);

                oldPlayerPosition = getPlayerPosition.GetPlayerPositionFunction(gameObject);
                print("oldPlayerPosition value: " + oldPlayerPosition);

            }

            if (Input.GetKey(KeyCode.S))
            {
                direction = Vector3.back;

                print(Vector3.down);
                playerPoint.position += new Vector3(0, 0, -moveSpeed);

                oldPlayerPosition = getPlayerPosition.GetPlayerPositionFunction(gameObject);
                print("oldPlayerPosition value: " + oldPlayerPosition);
            }

            if (Input.GetKey(KeyCode.D))
            {
                direction = Vector3.right;

                playerPoint.position += new Vector3(moveSpeed, 0, 0);

                oldPlayerPosition = getPlayerPosition.GetPlayerPositionFunction(gameObject);
                print("oldPlayerPosition value: " + oldPlayerPosition);

            }

            if (Input.GetKey(KeyCode.Space))
            {
                direction = Vector3.up;

                playerPoint.position += new Vector3(0, moveSpeed, 0);

                oldPlayerPosition = getPlayerPosition.GetPlayerPositionFunction(gameObject);
                print("oldPlayerPosition value: " + oldPlayerPosition);


                //change block color
            }

            if (Input.GetKey(KeyCode.LeftControl))
            {
                print(Vector3.down);

                direction = Vector3.down;

                playerPoint.position += new Vector3(0, -moveSpeed, 0);

                oldPlayerPosition = getPlayerPosition.GetPlayerPositionFunction(gameObject);
                print("oldPlayerPosition value: " + oldPlayerPosition);


                //change block color
            }
        }
    }
}
