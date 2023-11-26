using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnakeBody : MonoBehaviour
{
    [SerializeField]
    private Vector3 currentTransform;
    // Start is called before the first frame update
    void Start()
    {
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
        currentTransform = gameObject.transform.position;
    }
}
