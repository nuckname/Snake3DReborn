using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObjectPosition : MonoBehaviour
{
    public static Vector3 GetPlayerPositionFunction(GameObject player)
    {
        Vector3 playerGridPosition = new Vector3(
            Mathf.Round(player.transform.position.x),
            Mathf.Round(player.transform.position.y),
            Mathf.Round(player.transform.position.z)
        );

        return playerGridPosition;
    }
}
