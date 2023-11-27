using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeCollision : MonoBehaviour
{

    [SerializeField]
    private GameObject snakeBody;

    [SerializeField]
    private PlayerMovement playerMovement;

    private SpawnPower spawnPower;
    private SpawnSnakeBody spawnSnakeBody;

    private void Start()
    {
        spawnPower = FindObjectOfType<SpawnPower>();
        spawnSnakeBody = FindObjectOfType<SpawnSnakeBody>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("power"))
        {
            Vector3 direction;
            print(playerMovement.direction);
            direction = playerMovement.direction;
            //lets get the direction of the snake.
            Destroy(collision.gameObject);
            spawnPower.SpawningPower();


            spawnSnakeBody.SpawnSnakeBodyPart();

        }

        /*
        if (collision.gameObject.CompareTag("wall"))
        {
            print("wall hit");
        }
        */
    }
}
