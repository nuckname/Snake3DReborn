using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter : MonoBehaviour
{
    [SerializeField]
    private Camera camera;

    [SerializeField]
    private GridGenerator gridGenerator;

    private float centerOfWorldX;
    private float centerOfWorldZ;
    private Vector3 centerCameraCoordinates;

    void Start()
    {
        camera.transform.SetPositionAndRotation(CenterCamera(), Quaternion.Euler(90, 0, 0));
    }

    private Vector3 CenterCamera()
    {
        //* 3 becuase the size of the sqaure. [1,1,0 is 3,3,0
        centerOfWorldX = gridGenerator.gridY * 3 / 2;
        centerOfWorldZ = gridGenerator.gridX * 3 / 2;

        centerCameraCoordinates = new Vector3(centerOfWorldX, gridGenerator.gridY + 30, centerOfWorldZ);
        //print("Camera POS: " + centerCameraCoordinates);
        return centerCameraCoordinates;
    }
}
