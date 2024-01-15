using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject snakeBody;

    //useful for when the snake moves by itself. probs move to another script though. (playerMovement.direction)
    
    [SerializeField]
    private HistoryOfPlayerMovement playerMovement;
    

    [SerializeField]
    private GameManager gameManager;

    private void Start()
    {
        playerMovement = GetComponent<HistoryOfPlayerMovement>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("power"))
        {
            print("collision:" + collision);
            //Vector3 direction = playerMovement.direction;

            Destroy(collision.gameObject);

            gameManager.PlayerPowerCollision();
        }

        /*
        if (collision.gameObject.CompareTag("wall"))
        {
            print("wall hit");
        }
        */
    }
}
