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
        //debug: to remove OutOfRangeExpection
        oldPlayerPositions.Add(new Vector3(0, 0, 0));
    }

    //bad code = comment
    //called after every key press.

    //why this isnt working. need to change how i get int amountOfMoves int amountOfBodies.

    //call on snake collision on power
    public void PlayerHistoryList() 
    {
        //check on player col instead of played pressed down.
        int amountOfMoves = oldPlayerPositions.Count;
        int amountOfBodies = SpawnSnakeBody.amountOfBodiesSpawned;

        //checks if the list is full or not
        if (amountOfMoves <= amountOfBodies)
        {
            //fills up the list so we dont store excess playermovement data.
            //oldPlayerPositions.Add(GetObjectPosition.GetPlayerPositionFunction(gameObject));
            oldPlayerPositions[historyCounter] = GetObjectPosition.GetPlayerPositionFunction(gameObject);
            //ListIsFull();
        }
        else
        {
            //need to replace the old data with new data.
            oldPlayerPositions[historyCounter] = GetObjectPosition.GetPlayerPositionFunction(gameObject);

            if (historyCounter < amountOfBodies)
            {
                historyCounter++;
            }
        }
    }

    private void ListIsFull()
    {
        oldPlayerPositions[historyCounter] = GetObjectPosition.GetPlayerPositionFunction(gameObject);
    }
}
