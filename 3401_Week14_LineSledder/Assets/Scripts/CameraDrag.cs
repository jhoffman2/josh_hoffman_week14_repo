using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    private float cameraDistance;
    private Vector3 MouseStart;
    
    void Start()
    {
        cameraDistance = transform.position.z; 
    }

    void Update()
    {
        //Find Position of where mouse currently is
        if (Input.GetMouseButtonDown(1))
        {
            MouseStart = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraDistance);
            MouseStart = Camera.main.ScreenToWorldPoint(MouseStart);
            MouseStart.z = transform.position.z;
        }
        //Move Camera Position relative to mouse position
        else if (Input.GetMouseButton(1))
        {
            Vector3 MouseMove = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraDistance);
            MouseMove = Camera.main.ScreenToWorldPoint(MouseMove);
            MouseMove.z = transform.position.z;
            transform.position = transform.position - (MouseMove - MouseStart);
        }
    }
}