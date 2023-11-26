using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnakeHead : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private GetPlayerPosition getPlayerPosition;

    [SerializeField]
    private Vector3 testPlayerTransform;

    private float moveSpeed = 3f;

    [SerializeField]
    private Transform snakeHead;
    [SerializeField]
    private int bodyIndex = 0;

    private List<Transform> bodyParts = new List<Transform>();

    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();

        // Initialize the list with the snake head
        bodyParts.Add(snakeHead);

        // Create initial body parts (you can adjust this based on your game logic)
        for (int i = 0; i < 2; i++)
        {
            AddBodyPart();
        }
    }

    // Add a new body part to the snake
    void AddBodyPart()
    {
        GameObject newBodyPart = new GameObject("BodyPart" + bodyIndex);
        bodyIndex++;
        newBodyPart.transform.position = bodyParts[bodyParts.Count - 1].position;
        bodyParts.Add(newBodyPart.transform);
    }

    // Move all the body parts to their respective positions
    void MoveSnakeBody()
    {
        for (int i = bodyParts.Count - 1; i > 0; i--)
        {
            bodyParts[i].position = bodyParts[i - 1].position;
        }

        // Move the first body part to the head position
        bodyParts[0].position = snakeHead.position;
    }

    void Update()
    {
        testPlayerTransform = gameObject.transform.position;

        // Call MoveSnakeBody to update the positions of all body parts
        MoveSnakeBody();

        // Move the head towards the desired position
        snakeHead.position = Vector3.MoveTowards(snakeHead.position, playerMovement.oldPlayerPosition, moveSpeed * Time.deltaTime);
    }
}
