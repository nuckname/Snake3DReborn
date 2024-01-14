using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private SpawnPower spawnPower;
    [SerializeField]
    private SpawnSnakeBody spawnSnakeBody;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerPowerCollision()
    {
        spawnPower.SpawningPower();
        spawnSnakeBody.SpawnSnakeBodyPart();
        
    }

    public void MovingLogicOrder()
    {

    }
}
