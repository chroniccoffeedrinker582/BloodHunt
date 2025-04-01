using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script allows camera to follow player using CameraPos GameObj
public class CameraFollow : MonoBehaviour
{
    public Transform cameraPosition;
    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
