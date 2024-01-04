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

    //currnet bug. its not adding a new list in the else. use .add?
    public void PlayerHistoryList()
    {
        /*
        //switch this variable with something else.
        //calling this varaible too many times?
        
        int amountOfMoves = oldPlayerPositions.Count;
        int amountOfBodies = SpawnSnakeBody.amountOfBodiesSpawned;

        // Check if the list is full or not
        //4 <= 3
        if (amountOfMoves <= amountOfBodies)
        {
            // If there are fewer moves than bodies, add new positions to the list
            oldPlayerPositions.Add(new Vector3(0,0,0));
            historyCounter++;
        }
        else
        {
            historyCounter = 0;
        }
        */


        oldPlayerPositions.Add(new Vector3(0, 0, 0));

    }

    //PlayerHistoryList should only worry about if there is enough in the list and then we can add using this. 
    //called after each key press
    public void AddMovementWithCurrentListValue()
    {
        //each time we move lets go to the make histor counter
        //3 => 2
        print("historyCounter " + historyCounter);
        print("amountOfBodiesSpawned " + SpawnSnakeBody.amountOfBodiesSpawned);
         
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


    private void ListIsFull()
    {
        oldPlayerPositions[historyCounter] = GetObjectPosition.GetPlayerPositionFunction(gameObject);
    }
}
