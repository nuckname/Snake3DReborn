using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoryOfPlayerMovement : MonoBehaviour
{
    private int historyCounter = 0;

    //records the previous position.
    public List<Vector3> oldPlayerPositions = new List<Vector3>();

    void Start()
    {
        //One too many lists. Can fix later.
        oldPlayerPositions.Add(new Vector3(0, 0, 0));
    }


    //called after each key press
    public void AddMovementWithCurrentListValue()
    {
        if (SpawnSnakeBody.amountOfBodiesSpawned > historyCounter)
        {
            historyCounter++;
        }
        else
        {
            historyCounter = 0;
        }

        oldPlayerPositions[historyCounter] = GetObjectPosition.GetPlayerPositionFunction(gameObject);
        
    }
}
