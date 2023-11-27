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
    private GetPlayerPosition getPlayerPosition;

    public Vector3 oldPlayerPosition = new Vector3(0, 0, 0);

    public List<Vector3> oldPlayerPositions = new List<Vector3>();

    private int historyCounter = 0;

    private void Start()
    {
        playerPoint.parent = null;
        moveSpeed = 3f;
    }

    void MovePlayer(Vector3 movementDirection, Vector3 playerInputDirection)
    {
        direction = playerInputDirection;
        playerPoint.position += movementDirection;


        oldPlayerPosition = getPlayerPosition.GetPlayerPositionFunction(gameObject);
        print("oldPlayerPosition value: " + oldPlayerPosition);

        PlayerHistoryOfMovement();
    }

    void PlayerHistoryOfMovement()
    {

        if (oldPlayerPositions.Count <= SpawnSnakeBody.amountOfBodiesSpawned)
        {
            //fills up list
            oldPlayerPositions.Add(new Vector3(Mathf.Round(oldPlayerPosition.x), Mathf.Round(oldPlayerPosition.y), Mathf.Round(oldPlayerPosition.z)));
        }
        else
        {
            //replaces old list
            oldPlayerPositions[historyCounter] = (new Vector3(Mathf.Round(oldPlayerPosition.x), Mathf.Round(oldPlayerPosition.y), Mathf.Round(oldPlayerPosition.z)));
            
            if(historyCounter < SpawnSnakeBody.amountOfBodiesSpawned)
            {
                historyCounter += 1;
            }
            else
            {
                historyCounter = 0;
            }
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPoint.position, moveSpeed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, playerPoint.position) <= 0.05f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                MovePlayer(new Vector3(0, 0, moveSpeed), Vector3.forward);
                print("W Prsesed");
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
