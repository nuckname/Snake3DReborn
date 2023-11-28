using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnakeBody : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    [SerializeField]
    private Vector3 testPlayerTransformOldPlayerPosition;

    [SerializeField]
    private GetObjectPosition getObjectPosition;

    [SerializeField]
    private Vector3 currentTransform;
    // Start is called before the first frame update
    void Start()
    {
        testPlayerTransformOldPlayerPosition = getObjectPosition.GetPlayerPositionFunction(gameObject);
        testPlayerTransformOldPlayerPosition = this.gameObject.transform.position;
        print(SpawnSnakeBody.amountOfBodiesSpawned);
        int amountOfBodies = SpawnSnakeBody.amountOfBodiesSpawned;

    }

    private void Cals()
    {
        //loop over amount of bodies.
    }

    // Update is called once per frame
    void Update()
    {
        
        
        this.gameObject.transform.position = Vector3.MoveTowards(transform.position, testPlayerTransformOldPlayerPosition, moveSpeed * Time.deltaTime);

        //currentTransform = gameObject.transform.position;
    }
}
