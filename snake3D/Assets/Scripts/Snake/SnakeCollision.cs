using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeCollision : MonoBehaviour
{
    public SpawnPower spawnPower;

    [SerializeField]
    private GameObject snakeBody;

    [SerializeField]
    private PlayerMovement playerMovement;

    [SerializeField]
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

            /*
            float offset = -1.5f;
            Vector3 snakeBodySpawn = new Vector3(transform.position.x + direction.x * offset, transform.position.y + direction.y * offset, transform.position.z + direction.z * offset);
            Instantiate(snakeBody, snakeBodySpawn, Quaternion.identity);
            */

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
