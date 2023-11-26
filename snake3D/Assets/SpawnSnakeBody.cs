using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnakeBody : MonoBehaviour
{
    public static int amountOfBodiesSpawned;
    private PlayerMovement playerMovement;

    [SerializeField]
    private GameObject snakeBody;

    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    public void SpawnSnakeBodyPart()
    {
        amountOfBodiesSpawned += 1;
        Vector3 snakeBodyPosition = playerMovement.oldPlayerPosition;
        Instantiate(snakeBody, snakeBodyPosition, Quaternion.identity);
    }
}
