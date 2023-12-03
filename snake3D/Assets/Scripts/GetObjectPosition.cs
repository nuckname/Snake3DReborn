using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObjectPosition : MonoBehaviour
{
    public Vector3 GetPlayerPositionFunction(GameObject player)
    {
        Vector3 playerGridPosition = new Vector3(
        player.transform.position.x,
        player.transform.position.y,
        player.transform.position.z);

        //print("return  GetPlayerPositionFunction: " + playerGridPosition);
        return playerGridPosition;

    }
}
