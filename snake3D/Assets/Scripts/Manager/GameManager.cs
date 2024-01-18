using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private SpawnPower spawnPower;
    [SerializeField]
    private SpawnSnakeBody spawnSnakeBody;

    private HistoryOfPlayerMovement historyOfPlayerMovement;

    private PlayerMovement playerMovement;


    void Start()
    {
         historyOfPlayerMovement = FindObjectOfType<HistoryOfPlayerMovement>();

         playerMovement = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerPowerCollision()
    {
        spawnPower.SpawningPower();
        spawnSnakeBody.SpawnSnakeBodyPart();
        historyOfPlayerMovement.oldPlayerPositions.Add(new Vector3(0, 0, 0));

    }

    //called from PlayerMovement.cs
    //called from FollowSnakeHead.cs
    public void CalledAfterEachKeyPress()
    {

    }

    public void MovingLogicOrder()
    {

    }
}
